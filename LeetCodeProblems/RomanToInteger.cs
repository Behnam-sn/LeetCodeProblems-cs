namespace LeetCodeProblems;

// https://leetcode.com/problems/roman-to-integer/description/

public class RomanToInteger
{
    public static int Solution1(string s)
    {
        if (s == null || s == "")
        {
            return 0;
        }

        var numerals = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };
        var sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var symbol = s[i];

            if (i + 1 < s.Length)
            {
                var nextSymbol = s[i + 1];
                if (
                    (symbol == 'I' && (nextSymbol == 'V' || nextSymbol == 'X')) ||
                    (symbol == 'X' && (nextSymbol == 'L' || nextSymbol == 'C')) ||
                    (symbol == 'C' && (nextSymbol == 'D' || nextSymbol == 'M'))
                    )
                {
                    sum -= numerals[symbol];
                    continue;
                }
            }

            sum += numerals[symbol];
        }

        return sum;
    }

    public static int Solution2(string s)
    {
        if (s == null || s == "")
        {
            return 0;
        }

        var numerals = new Dictionary<char, int>
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };
        var sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            var symbol = s[i];

            if (i + 1 < s.Length)
            {
                var nextSymbol = s[i + 1];
                if (numerals[symbol] < numerals[nextSymbol])
                {
                    sum -= numerals[symbol];
                    continue;
                }
            }

            sum += numerals[symbol];
        }

        return sum;
    }
}
