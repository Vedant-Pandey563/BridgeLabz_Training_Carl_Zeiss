public class Solution
{
    public int TimeRequiredToBuy(int[] tickets, int k)
    {
        Queue<int> q = new Queue<int>();

        for (int i = 0; i < tickets.Length; i++)
            q.Enqueue(i);

        int time = 0;

        while (q.Count != 0)
        {
            int x = q.Dequeue();
            time++;
            tickets[x] -= 1;

            if (tickets[x] == 0 && x == k)
            {
                return time;
            }
            else if (tickets[x] > 0)
            {
                q.Enqueue(x);
            }
        }

        return time;

    }
}