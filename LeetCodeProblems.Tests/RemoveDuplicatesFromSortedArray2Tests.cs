namespace LeetCodeProblems.Tests;

public class RemoveDuplicatesFromSortedArray2Tests
{
    [Theory]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 1 }, new int[] { 1 })]
    [InlineData(new int[] { 1, 1 }, new int[] { 1, 1 })]
    [InlineData(new int[] { 1, 2 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 1, 2 })]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
    [InlineData(new int[] { 1, 1, 1, 2, 2, 3 }, new int[] { 1, 1, 2, 2, 3 })]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }, new int[] { 0, 0, 1, 1, 2, 3, 3 })]
    public void Test(int[] nums, int[] expected)
    {
        // Given
        // When
        var k = RemoveDuplicatesFromSortedArray2.Solution2(nums);
        // Then
        Assert.Equal(expected.Length, k);
        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], nums[i]);
        }
    }
}
