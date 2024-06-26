namespace LeetCodeProblems.Tests;

public class MajorityElementTests
{
    [Theory]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 1, 2 }, 1)]
    [InlineData(new int[] { 3, 2, 3 }, 3)]
    [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
    public void Test(int[] nums, int expected)
    {
        // Given
        // When
        var actual = MajorityElement.Solution(nums);
        // Then
        Assert.Equal(expected, actual);
    }
}
