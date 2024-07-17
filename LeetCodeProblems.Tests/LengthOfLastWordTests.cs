namespace LeetCodeProblems.Tests;

public class LengthOfLastWordTests
{
    [Theory]
    [InlineData(null, 0)]
    [InlineData("", 0)]
    [InlineData(" ", 0)]
    [InlineData("a", 1)]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void Test(string s, int expected)
    {
        // Given
        // When
        var actual = LengthOfLastWord.Solution1(s);
        // Then
        Assert.Equal(expected, actual);
    }
}
