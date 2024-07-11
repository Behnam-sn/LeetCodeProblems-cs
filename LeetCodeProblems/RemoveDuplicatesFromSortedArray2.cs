namespace LeetCodeProblems;

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
}