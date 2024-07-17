namespace LeetCodeProblems.Tests;

public class LongestCommonPrefixTests
{
    [Theory]
    [InlineData(null, "")]
    [InlineData(new string[] { }, "")]
    [InlineData(new string[] { "flower" }, "flower")]
    [InlineData(new string[] { "flower", "flower" }, "flower")]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    public void Test(string[] strs, string expected)
    {
        // Given
        // When
        var actual = LongestCommonPrefix.Solution4(strs);
        // Then
        Assert.Equal(expected, actual);
    }
}
