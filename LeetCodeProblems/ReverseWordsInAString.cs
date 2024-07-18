namespace LeetCodeProblems;

// https://leetcode.com/problems/reverse-words-in-a-string/description/

public class ReverseWordsInAString
{
    // Two Pointer
    // String
    public static string Solution1(string s)
    {
        if (s == null || s == "" || s == " ")
        {
            return "";
        }

        if (s.Length == 1)
        {
            return s;
        }

        var result = "";
        var head = s.Length;
        var tail = s.Length;

        for (var i = s.Length - 1; i > -2; i--)
        {
            if (i == -1 || s[i] == ' ')
            {
                if (head == tail)
                {
                    head = i;
                    tail = i;
                    continue;
                }

                result += s[head..tail] + " ";
                head = i;
                tail = i;
            }
            else
            {
                head = i;
            }
        }

        return result[..^1];
    }

    // Two Pointer
    // Array
    // Optimized
    public static string Solution2(string s)
    {
        if (s == null || s == "" || s == " ")
        {
            return "";
        }

        if (s.Length == 1)
        {
            return s;
        }

        var words = new List<string>();
        var tail = s.Length;

        for (var i = s.Length - 1; i > -2; i--)
        {
            if (i == -1 || s[i] == ' ')
            {
                if (i + 1 != tail)
                {
                    words.Add(s[(i + 1)..tail]);
                }
                tail = i;
            }
        }

        return string.Join(" ", words);
    }

    // Fancy C#
    // LINQ
    public static string Solution3(string s)
    {
        if (s == null || s == "" || s == " ")
        {
            return "";
        }

        if (s.Length == 1)
        {
            return s;
        }

        var words = s.Split(' ');
        words = words.Where(w => w != "").ToArray();
        Array.Reverse(words);
        return string.Join(" ", words);
    }

    // Fancy C#
    public static string Solution4(string s)
    {
        if (s == null || s == "" || s == " ")
        {
            return "";
        }

        if (s.Length == 1)
        {
            return s;
        }

        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);
        return string.Join(" ", words);
    }
}
