namespace LeetCodeProblems.Tests;

public class BestTimeToBuyAndSellStock2Tests
{
    [Theory]
    [InlineData(new int[] { 1 }, 0)]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void Test(int[] prices, int expected)
    {
        // Given
        // When
        var actual = BestTimeToBuyAndSellStock2.Solution1(prices);
        // Then
        Assert.Equal(expected, actual);
    }
}