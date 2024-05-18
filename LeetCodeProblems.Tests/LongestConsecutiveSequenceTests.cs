namespace LeetCodeProblems.Tests;

public class LongestConsecutiveSequenceTests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, 3)]
    [InlineData(new int[] { 3, 2, 1 }, 3)]
    [InlineData(new int[] { 3, 2, 1, 4 }, 4)]
    [InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
    [InlineData(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 }, 9)]
    public void Test_Pass(int[] numbers, int expected)
    {
        // Given
        // When
        var actual = LongestConsecutiveSequence.Solution(numbers);
        // Then
        Assert.Equal(expected, actual);
    }
}