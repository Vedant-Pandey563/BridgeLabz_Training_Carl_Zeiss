class Solution
{
    public Queue<int> reverseFirstK(Queue<int> q, int k)
    {
        // code here
        if (k > q.Count)
            return q;

        Stack<int> s = new Stack<int>();

        for (int i = 0; i < k; i++)
        {
            int x = q.Dequeue();
            s.Push(x);
        }

        Queue<int> q2 = new Queue<int>();

        while (s.Count > 0)
        {
            int x = s.Pop();
            q2.Enqueue(x);
        }

        while (q.Count > 0)
        {
            int x = q.Dequeue();
            q2.Enqueue(x);
        }

        return q2;
    }
}