namespace LeetCodeProblems.Tests;

public class MedianofTwoSortedArraysTests
{
    [Theory]
    [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2.00000)]
    [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.50000)]
    [InlineData(new int[] { 1, 1 }, new int[] { 1, 2 }, 1.00000)]
    public void Test(int[] nums1, int[] nums2, double expected)
    {
        // Given
        // When
        var actual = MedianofTwoSortedArrays.Solution(nums1, nums2);
        // Then
        Assert.Equal(expected, actual);
    }
}
