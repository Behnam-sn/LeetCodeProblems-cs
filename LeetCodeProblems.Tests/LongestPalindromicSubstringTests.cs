namespace LeetCodeProblems.Tests;

public class LongestPalindromicSubstringTests
{
    [Theory]
    [InlineData("a", new string[] { "a" })]
    [InlineData("babad", new string[] { "aba", "bab" })]
    [InlineData("cbbd", new string[] { "bb" })]
    [InlineData("cbbbbd", new string[] { "bbbb" })]
    [InlineData("", new string[] { "" })]
    public void Test_Pass(string s, string[] collection)
    {
        // Given
        // When
        var expected = LongestPalindromicSubstring.Solution(s);
        // Then
        Assert.Contains(expected, collection);
    }

    [Fact]
    public void Test2()
    {
        // Given
        var s = "abcd";
        // When
        var actual = LongestPalindromicSubstring.Solution(s);
        // Then
        Assert.Contains(actual, s);
    }
}
