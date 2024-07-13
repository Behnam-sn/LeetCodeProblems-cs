namespace LeetCodeProblems;

// https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/

public class RemoveDuplicatesFromSortedArray1
{
    public static int Solution1(int[] nums)
    {
        var hashSet = new HashSet<int>();

        foreach (var item in nums)
        {
            hashSet.Add(item);
        }

        var index = 0;
        foreach (var item in hashSet)
        {
            nums[index] = item;
            index++;
        }

        return hashSet.Count;
    }

    public static int Solution2(int[] nums)
    {
        var duplicateCount = 0;
        var currentItem = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == currentItem)
            {
                nums[i] = int.MaxValue;
                duplicateCount++;
            }
            else
            {
                currentItem = nums[i];
            }
        }
        Array.Sort(nums);

        return nums.Length - duplicateCount;
    }

    public static int Solution3(int[] nums)
    {
        var j = 1;
        var currentItem = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != currentItem)
            {
                nums[j] = nums[i];
                currentItem = nums[i];
                j++;
            }
        }

        return j;
    }

    public static int Solution4(int[] nums)
    {
        var j = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[j] = nums[i];
                j++;
            }
        }

        return j;
    }
}
