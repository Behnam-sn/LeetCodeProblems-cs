namespace LeetCodeProblems.Tests;

public class ReverseWordsInAStringTests
{
    [Theory]
    [InlineData(null, "")]
    [InlineData("", "")]
    [InlineData(" ", "")]
    [InlineData("a", "a")]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void Test(string s, string expected)
    {
        // Given
        // When
        var actual = ReverseWordsInAString.Solution2(s);
        // Then
        Assert.Equal(expected, actual);
    }
}
