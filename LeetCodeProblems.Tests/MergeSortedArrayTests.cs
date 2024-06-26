namespace LeetCodeProblems.Tests;

public class MergeSortedArrayTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })]
    [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })]
    [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
    public void Test(int[] nums1, int m, int[] nums2, int n, int[] expected)
    {
        // Given
        // When
        MergeSortedArray.Solution(nums1, m, nums2, n);
        // Then
        Assert.Equal(expected, nums1);
    }
}
