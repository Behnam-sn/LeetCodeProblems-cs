namespace LeetCodeProblems.Tests;

public class BiggestSubsetOfSumOfNTests
{
    [Theory]
    [InlineData(new int[] { }, 1, new int[] { })]
    [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 4 }, 10, new int[] { 1, 2, 3, 4 })]
    [InlineData(new int[] { 1, 2, 3, 4 }, 9, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 1, 4, 7, 8, 2, 4 }, 9, new int[] { 1, 2, 4 })]
    public void Test(int[] nums, int val, int[] expected)
    {
        // Given
        // When
        var actual = BiggestSubsetOfSumOfN.Solution(nums, val);
        // Then
        Assert.Equal(expected, actual);
    }
}