using System;
using System.Collections.Generic;

public class TestResult
{
    public string TestId;
    public string MachineId;
    public long Timestamp;
    public double ResultValue;

    public TestResult(string testId, string machineId, long timestamp, double value)
    {
        TestId = testId;
        MachineId = machineId;
        Timestamp = timestamp;
        ResultValue = value;
    }
}

public class OpticalTestSystem
{
    // Prevent duplicates
    private HashSet<string> testIdSet = new HashSet<string>();

    // Store results per machine
    private Dictionary<string, LinkedList<TestResult>> machineData
        = new Dictionary<string, LinkedList<TestResult>>();

    // Track insertion order for undo
    private Stack<TestResult> undoStack = new Stack<TestResult>();

    // Track timestamps for expiry
    private Queue<TestResult> expiryQueue = new Queue<TestResult>();

    private const long TEN_MINUTES = 600_000; // milisec


    //insert new result 
    public bool Insert(TestResult result, long currentTime)
    {
        // Duplicate check
        if (testIdSet.Contains(result.TestId))
            return false; // reject duplicate

        testIdSet.Add(result.TestId);

        // 2) Store per machine (Deque using LinkedList)
        if (!machineData.ContainsKey(result.MachineId))
            machineData[result.MachineId] = new LinkedList<TestResult>();

        machineData[result.MachineId].AddLast(result);

        // 3) Track insertion order undo
        undoStack.Push(result);

        // 4) Track for expiry
        expiryQueue.Enqueue(result);

        // 5) Remove old records
        CleanupOldRecords(currentTime);

        return true;
    }

    //latest n results for machine
    public List<TestResult> GetLatestResults(string machineId, int N)
    {
        List<TestResult> output = new List<TestResult>();

        if (!machineData.ContainsKey(machineId))
            return output;

        var deque = machineData[machineId];

        var node = deque.Last;
        while (node != null && N > 0)
        {
            output.Add(node.Value);
            node = node.Previous;
            N--;
        }

        return output;
    }

    // undo latest insert
    public void UndoLastInsert()
    {
        if (undoStack.Count == 0) return;

        TestResult last = undoStack.Pop();

        // Remove from duplicate set
        testIdSet.Remove(last.TestId);

        // Remove from machine deque
        if (machineData.ContainsKey(last.MachineId))
            machineData[last.MachineId].Remove(last);
    }

    // remove record older than 10 min
    private void CleanupOldRecords(long currentTime)
    {
        while (expiryQueue.Count > 0 &&
               currentTime - expiryQueue.Peek().Timestamp > TEN_MINUTES)
        {
            TestResult old = expiryQueue.Dequeue();

            // Remove from hashset
            testIdSet.Remove(old.TestId);

            // Remove from machine deque
            if (machineData.ContainsKey(old.MachineId))
                machineData[old.MachineId].Remove(old);
        }
    }
}
public class Program
{
    public static void Main()
    {
        OpticalTestSystem system = new OpticalTestSystem();
        long now = 1_000_000;

        system.Insert(new TestResult("T1", "M1", now, 78.5), now);
        system.Insert(new TestResult("T2", "M1", now + 1, 80.2), now + 1);
        system.Insert(new TestResult("T3", "M2", now + 2, 65.1), now + 2);

        // latest 2 results of M1
        var latest = system.GetLatestResults("M1", 2);

        Console.WriteLine("Latest results for M1:");
        foreach (var r in latest)
            Console.WriteLine($"{r.TestId} -> {r.ResultValue}");

        // Undo last insert
        system.UndoLastInsert();
    }
}

