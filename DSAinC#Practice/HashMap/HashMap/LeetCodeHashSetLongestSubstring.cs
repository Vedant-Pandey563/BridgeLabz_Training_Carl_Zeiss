public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new HashSet<char>();
        int l = 0;
        int result = 0;

        for (int r = 0; r < s.Length; r++)
        {
            while (set.Contains(s[r]))
            {
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[r]);
            result = Math.Max(result, (r - l) + 1);
        }

        return result;

    }
}