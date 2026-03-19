public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        int[][] parr = new int[position.Length][];


        for (int i = 0; i < position.Length; i++)
        {
            parr[i] = new int[] { position[i], speed[i] };
        }

        Array.Sort(parr, (a, b) => b[0].CompareTo(a[0]));

        Stack<double> s = new Stack<double>();

        foreach (var x in parr)
        {
            s.Push((double)(target - x[0]) / x[1]);

            if (s.Count >= 2 && s.Peek() <= s.ElementAt(1))
            {
                s.Pop();
            }

        }

        return s.Count;
    }
}