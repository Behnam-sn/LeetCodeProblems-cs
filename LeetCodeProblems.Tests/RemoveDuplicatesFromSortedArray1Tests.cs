namespace LeetCodeProblems.Tests;

public class RemoveDuplicatesFromSortedArray1Tests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 })]
    public void Test(int[] nums, int[] expected)
    {
        // Given
        // When
        var k = RemoveDuplicatesFromSortedArray1.Solution4(nums);
        // Then
        Assert.Equal(expected.Length, k);
        for (var i = 0; i < expected.Length; i++)
        {
            Assert.Equal(expected[i], nums[i]);
        }
    }
}
