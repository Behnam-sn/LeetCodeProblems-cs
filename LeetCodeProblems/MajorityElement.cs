namespace LeetCodeProblems;

// https://leetcode.com/problems/majority-element/description/

public class MajorityElement
{
    public static int Solution(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return nums.First();
        }

        var items = new Dictionary<int, int>();

        foreach (var item in nums)
        {
            if (items.ContainsKey(item))
            {
                items[item]++;
            }
            else
            {
                items[item] = 1;
            }
        }

        return items.MaxBy(item => item.Value).Key;
    }
}
