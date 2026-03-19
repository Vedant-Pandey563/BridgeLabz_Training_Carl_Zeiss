public class Solution
{
    public int[] DailyTemperatures(int[] temp)
    {
        int[] res = new int[temp.Length];

        Stack<int[]> s = new Stack<int[]>();

        for (int i = 0; i < temp.Length; i++)
        {
            while ((s.Count > 0) && temp[i] > s.Peek()[0])
            {
                int[] pair = s.Pop();//store popped element
                res[pair[1]] = i - pair[1];// stack index - popped index
            }
            //push the  current element in to stack if larger not found 
            s.Push(new int[] { temp[i], i });
        }

        return res;
    }
}