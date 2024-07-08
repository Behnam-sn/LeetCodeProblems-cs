
namespace LeetCodeProblems;

// https://leetcode.com/problems/remove-element/description/

public class RemoveElement
{
    public static int Solution(int[] nums, int val)
    {
        var valOccurrenceCount = 0;
        var j = nums.Length - 1;

        for (var i = 0; i <= j; i++)
        {
            while (j >= 0 && nums[j] == val)
            {
                j--;
                valOccurrenceCount++;
            }

            if (j < i)
            {
                break;
            }

            if (nums[i] == val)
            {
                nums[i] = nums[j];
                nums[j] = val;
                j--;
                valOccurrenceCount++;
            }
        }

        return nums.Length - valOccurrenceCount;
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
