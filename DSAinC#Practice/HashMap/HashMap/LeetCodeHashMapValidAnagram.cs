public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> FreqS = new Dictionary<char, int>();
        Dictionary<char, int> FreqT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            FreqS[s[i]] = FreqS.GetValueOrDefault(s[i], 0) + 1;
            FreqT[t[i]] = FreqT.GetValueOrDefault(t[i], 0) + 1;
        }
        return FreqS.Count == FreqT.Count && !FreqS.Except(FreqT).Any();
    }
}