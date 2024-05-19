namespace LeetCodeProblems;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int Solution(string s)
    {
        var longest = 0;
        List<char> charList;

        for (int i = 0; i < s.Length; i++)
        {
            charList = new List<char>();

            for (int j = i; j < s.Length; j++)
            {
                if (charList.Contains(s[j])) break;

                charList.Add(s[j]);
            }

            if (charList.Count > longest) longest = charList.Count;
        }

        return longest;
    }
}