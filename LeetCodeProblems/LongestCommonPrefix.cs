namespace LeetCodeProblems;

// https://leetcode.com/problems/longest-common-prefix/description/

public class LongestCommonPrefix
{
    public static string Solution1(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }

        var commonPrefix = strs[0];
        for (var i = 1; i < strs.Length; i++)
        {
            var item = strs[i];

            var j = 0;
            var minLength = Math.Min(commonPrefix.Length, item.Length);
            while (j < minLength)
            {
                if (commonPrefix[j] != item[j])
                {
                    break;
                }
                j++;
            }
            commonPrefix = commonPrefix[..j];

            if (commonPrefix == "")
            {
                return "";
            }
        }

        return commonPrefix;
    }

    // Not Original
    public static string Solution2(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }

        var commonPrefix = "";
        var smallestItem = strs.MinBy(str => str.Length);
        for (var i = 0; i < smallestItem!.Length; i++)
        {
            var currentCharacter = smallestItem[i];
            for (var j = 0; j < strs.Length; j++)
            {
                if (strs[j][i] != currentCharacter)
                {
                    return commonPrefix;
                }
            }

            commonPrefix += currentCharacter;
        }
        return commonPrefix;
    }

    public static string Solution3(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        if (strs.Length == 1)
        {
            return strs[0];
        }

        var commonPrefix = "";
        var i = 0;
        while (true)
        {
            try
            {
                var currentCharacter = strs[0][i];
                for (var j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] != currentCharacter)
                    {
                        return commonPrefix;
                    }
                }
                commonPrefix += currentCharacter;
                i++;
            }
            catch (Exception)
            {
                break;
            }
        }
        return commonPrefix;
    }

    // LINQ
    public static string Solution4(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return string.Empty;
        }

        if (strs.Length == 1)
        {
            return strs.First();
        }

        var commonPrefix = string.Empty;
        var i = 0;
        while (true)
        {
            try
            {
                var currentCharacter = strs.First()[i];
                if (!strs.All(str => str[i] == currentCharacter))
                {
                    return commonPrefix;
                }
                commonPrefix += currentCharacter;
                i++;
            }
            catch (Exception)
            {
                break;
            }
        }
        return commonPrefix;
    }
}
