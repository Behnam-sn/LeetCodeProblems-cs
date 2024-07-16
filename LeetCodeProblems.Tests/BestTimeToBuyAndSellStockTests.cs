namespace LeetCodeProblems.Tests;

public class BestTimeToBuyAndSellStockTests
{
    [Theory]
    [InlineData(null, 0)]
    [InlineData(new int[] { }, 0)]
    [InlineData(new int[] { 1 }, 0)]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new int[] { 7, 6, 4, 3, 1 }, 0)]
    [InlineData(new int[] { 2, 1, 2, 0, 1 }, 1)]
    public void Test(int[] prices, int expected)
    {
        // Given
        // When
        var actual = BestTimeToBuyAndSellStock.Solution2(prices);
        // Then
        Assert.Equal(expected, actual);
    }
}