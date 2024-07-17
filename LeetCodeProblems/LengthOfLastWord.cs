namespace LeetCodeProblems;

// https://leetcode.com/problems/length-of-last-word/submissions/

public class LengthOfLastWord
{
    public static int Solution1(string s)
    {
        if (s == null || s == "" || s == " ")
        {
            return 0;
        }

        if (s.Length == 1)
        {
            return 1;
        }

        var length = 0;
        for (var i = s.Length - 1; i > -1; i--)
        {
            if (s[i] == ' ')
            {
                if (length == 0)
                {
                    continue;
                }
                else
                {
                    return length;
                }
            }
            length++;
        }
        return length;
    }
}
