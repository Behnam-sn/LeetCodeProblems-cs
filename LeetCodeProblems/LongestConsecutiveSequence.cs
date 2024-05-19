namespace LeetCodeProblems;

public class LongestConsecutiveSequence
{
    public static int Solution(int[] nums)
    {
        if (nums.Length < 0)
        {
            return nums.Length;
        }

        var items = new HashSet<int>(nums);
        var longest = 0;

        foreach (var item in items)
        {
            if (items.Contains(item - 1))
            {
                continue;
            }

            var length = 0;
            while (items.Contains(item + length))
            {
                length++;
            }
            longest = Math.Max(longest, length);
        }

        return longest;
    }

    public static int Solution2(int[] nums)
    {
        if (nums.Length < 0)
        {
            return nums.Length;
        }

        var items = new HashSet<int>(nums);
        var dict = new Dictionary<int, int>();
        var longest = 0;

        foreach (var item in items)
        {
            var x = dict.GetValueOrDefault(item - 1, 0);
            var y = dict.GetValueOrDefault(item + 1, 0);
            var value = x + y + 1;
            dict[item - x] = value;
            dict[item + y] = value;
            longest = Math.Max(longest, value);
        }

        return longest;
    }

    public static int Solution1(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var count = 1;
        var maxCount = 1;
        var index = 0;

        while (index < nums.Length)
        {
            var value = nums[index];
            var next = value + count;
            if (nums.Contains(next))
            {
                count++;
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }
            else
            {
                count = 1;
                index++;
            }
        }

        return maxCount;
    }
}