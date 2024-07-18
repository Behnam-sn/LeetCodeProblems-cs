namespace LeetCodeProblems.Tests;

public class ValidAnagramTests
{
    [Theory]
    [InlineData("anagram", "nagaram", true)]
    [InlineData("rat", "car", false)]
    public void Test(string s, string t, bool expected)
    {
        // Given
        var actual = ValidAnagram.Solution(s, t);
        // Then
        Assert.Equal(expected, actual);
    }
}
