
namespace LeetCodeProblems;

// https://leetcode.com/problems/remove-element/description/

public class RemoveElement
{
    public static int Solution(int[] nums, int val)
    {
        var k = 0;
        var j = nums.Length - 1;

        for (var i = 0; i <= j; i++)
        {
            if (nums[i] == val)
            {
                k++;
                while (nums[j] == val && j != 0 && i != j)
                {
                    j--;
                    k++;
                }

                if (i != j)
                {
                    nums[i] = nums[j];
                    nums[j] = val;
                    j--;
                }
            }
        }

        return nums.Length - k;
    }

    public static int Solution1(int[] nums, int val)
    {
        var k = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                nums[i] = int.MaxValue;
                k++;
            }
        }
        Array.Sort(nums);

        return nums.Length - k;
    }
}
