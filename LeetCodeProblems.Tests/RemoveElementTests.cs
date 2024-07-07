namespace LeetCodeProblems.Tests;

public class RemoveElementTests
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 4, 0, 3 })]
    [InlineData(new int[] { 1 }, 1, new int[] { })]
    [InlineData(new int[] { 2, 2, 3 }, 2, new int[] { 3 })]
    public void Test(int[] nums, int val, int[] expected)
    {
        // Given
        // When
        var k = RemoveElement.Solution(nums, val);
        // Then
        Assert.Equal(expected.Length, k);
        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(nums[i], expected[i]);
        }
    }

    [Theory]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 0, 1, 3, 4 })]
    public void TestSorted(int[] nums, int val, int[] expected)
    {
        // Given
        // When
        var k = RemoveElement.Solution1(nums, val);
        // Then
        Assert.Equal(expected.Length, k);
        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(nums[i], expected[i]);
        }
    }
}
