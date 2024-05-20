namespace LeetCodeProblems.Tests;

public class ProductOfArrayExceptSelfTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
    [InlineData(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
    public void Test(int[] nums, int[] expected)
    {
        // Given
        // When
        var actual = ProductOfArrayExceptSelf.Solution(nums);
        // Then
        Assert.Equal(expected, actual);
    }
}