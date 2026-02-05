public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach (int n in set)
        {
            if (!set.Contains((n - 1)))
            {
                int length = 1;
                while (set.Contains(n + length))
                {
                    length++;
                }

                longest = Math.Max(longest, length);
            }

        }

        return longest;
    }
}