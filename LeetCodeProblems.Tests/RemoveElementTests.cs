namespace LeetCodeProblems.Tests;

public class RemoveElementTests
{
    [Theory]
    [InlineData(new int[] { 1 }, 1, new int[] { })]
    [InlineData(new int[] { 1, 2, 3 }, 1, new int[] { 3, 2 })]
    [InlineData(new int[] { 2, 3 }, 1, new int[] { 2, 3 })]
    [InlineData(new int[] { 2, 2, 3 }, 2, new int[] { 3 })]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 })]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 3, 0, 4 })]
    public void Test(int[] nums, int val, int[] expected)
    {
        // Given
        // When
        var k = RemoveElement.Solution3(nums, val);
        var actual = nums[..k];
        Array.Sort(actual);
        Array.Sort(expected);
        // Then
        Assert.Equal(expected.Length, k);
        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], actual[i]);
        }
    }
}
