namespace LeetCodeProblems;

// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description/

public class RemoveDuplicatesFromSortedArray2
{
    public static int Solution1(int[] nums)
    {
        if (nums.Length < 3)
        {
            return nums.Length;
        }

        var j = nums[0] == nums[1] ? 2 : 1;
        var current = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != current)
            {
                nums[j] = nums[i];
                j++;

                if (i + 1 < nums.Length && nums[i + 1] == nums[i])
                {
                    nums[j] = nums[i];
                    j++;
                }

                current = nums[i];
            }
        }

        return j;
    }

    public static int Solution2(int[] nums)
    {
        if (nums.Length < 3)
        {
            return nums.Length;
        }

        var j = 2;
        for (var i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[j - 2])
            {
                nums[j] = nums[i];
                j++;
            }
        }

        return j;
    }
}