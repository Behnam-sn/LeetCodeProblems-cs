namespace LeetCodeProblems;

public class MedianofTwoSortedArrays
{
    public static double Solution(int[] nums1, int[] nums2)
    {
        var merged = nums1.Concat(nums2).ToArray();
        Array.Sort(merged);

        if (merged.Length % 2 == 1)
        {
            return merged[merged.Length / 2];
        }

        return (double)(merged[merged.Length / 2 - 1] + merged[merged.Length / 2]) / 2;
    }
}