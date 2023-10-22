namespace LeetCodeProblems.Domain;

public class LongestPalindromicSubstring
{
    public static string ReverseString(string str)
    {
        return new string(str.Reverse().ToArray());
    }

    public string FirstSolution(string s)
    {
        var palindromic = "";

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 1; j <= s.Length - i; j++)
            {
                var substring = s.Substring(i, j);
                if (substring == ReverseString(substring))
                {
                    if (substring.Length > palindromic.Length) palindromic = substring;
                }
            }
        }

        return palindromic;
    }

    private int expandAroundCenter(String s, int left, int right)
    {
        var L = left;
        var R = right;
        while (L >= 0 && R < s.Length && s[L] == s[R])
        {
            L--;
            R++;
        }
        return R - L - 1;
    }

    public string SecondSolution(string? s)
    {
        if (s == null || s.Length < 1) return "";

        var start = 0;
        var end = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int len1 = expandAroundCenter(s, i, i);
            int len2 = expandAroundCenter(s, i, i + 1);

            int len = Math.Max(len1, len2);

            if (len > end - start)
            {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }

        var length = end - start + 1;
        return s.Substring(start, length);
    }

    private int Expand(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return right - left - 1;
    }

    public string Solution(string? s)
    {
        if (s == null || s.Length < 1) return "";

        var start = 0;
        var length = 1;

        for (int i = 0; i < s.Length; i++)
        {
            var len1 = Expand(s, left: i - 1, right: i + 1);
            var len2 = Expand(s, left: i, right: i + 1);

            var len = Math.Max(len1, len2);

            if (len > length)
            {
                start = i - (len - 1) / 2;
                length = len;
            }
        }

        return s.Substring(start, length);
    }
}