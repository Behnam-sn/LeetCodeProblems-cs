namespace LeetCodeProblems.Domain;

public class ValidAnagram
{
    public bool Solution(string s, string t)
    {
        var sChars = ConvertStringToListOfChars(s);
        var tChars = ConvertStringToListOfChars(t);

        sChars.Sort();
        tChars.Sort();

        return Enumerable.SequenceEqual(sChars, tChars);
    }

    public bool Solution1(string s, string t)
    {
        if (s.Length != t.Length) return false;
        if (s == t) return true;

        var sCounts = new Dictionary<char, int>();
        var tCounts = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            sCounts[s[i]] = 1 + (sCounts.ContainsKey(s[i]) ? sCounts[s[i]] : 0);
            tCounts[t[i]] = 1 + (tCounts.ContainsKey(t[i]) ? tCounts[t[i]] : 0);
        }

        foreach (char c in sCounts.Keys)
        {
            int tCount = tCounts.ContainsKey(c) ? tCounts[c] : 0;
            if (sCounts[c] != tCount) return false;
        }
        return true;
    }

    public static List<char> ConvertStringToListOfChars(string str)
    {
        return new List<char>(str);
    }
}