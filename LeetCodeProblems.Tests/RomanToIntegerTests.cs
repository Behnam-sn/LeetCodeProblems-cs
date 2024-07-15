namespace LeetCodeProblems.Tests;

public class RomanToIntegerTests
{
    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData("I", 1)]
    [InlineData("III", 3)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Test(string s, int expected)
    {
        // Given
        // When
        var actual = RomanToInteger.Solution2(s);
        // Then
        Assert.Equal(expected, actual);
    }
}
