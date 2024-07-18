namespace LeetCodeProblems;

public class FindTheIndexOfTheFirstOccurrenceInAString
{
    public static int Solution1(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        for (var i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if (haystack.Length - i < needle.Length)
                {
                    return -1;
                }

                var isMatched = true;
                for (var j = 1; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        isMatched = false;
                        break;
                    }
                }

                if (isMatched == true)
                {
                    return i;
                }
            }
        }

        return -1;
    }

    public static int Solution2(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        for (var i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                if (haystack.Length - i < needle.Length)
                {
                    return -1;
                }

                var j = 1;
                while (j < needle.Length && haystack[i + j] == needle[j])
                {
                    j++;
                }

                if (j == needle.Length)
                {
                    return i;
                }
            }
        }

        return -1;
    }

    // Not Working
    public static int Solution3(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        var j = 0;

        for (var i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[j])
            {
                j++;
                if (j == needle.Length)
                {
                    return i - (j - 1);
                }
            }
            else
            {
                j = 0;
            }
        }

        return -1;
    }

    // Fancy C#
    public static int Solution4(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}
