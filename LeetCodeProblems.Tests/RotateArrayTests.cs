namespace LeetCodeProblems.Tests;

public class RotateArrayTests
{
    [Theory]
    [InlineData(new int[] { }, 0, new int[] { })]
    [InlineData(new int[] { 1 }, 1, new int[] { 1 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [InlineData(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    [InlineData(new int[] { 1, 2 }, 2, new int[] { 1, 2 })]
    [InlineData(new int[] { 1, 2 }, 3, new int[] { 2, 1 })]
    [InlineData(new int[] { 1, 2, 3 }, 4, new int[] { 3, 1, 2 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 11, new int[] { 2, 3, 4, 5, 6, 1 })]
    public void Test(int[] nums, int k, int[] expected)
    {
        // Given
        // When
        RotateArray.Solution6(nums, k);
        // Then
        Assert.Equal(expected, nums);
    }
}
