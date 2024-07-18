namespace LeetCodeProblems.Tests;

public class FindTheIndexOfTheFirstOccurrenceInAStringTests
{
    [Theory]
    [InlineData("sadbutsad", "sad", 0)]
    [InlineData("leetcode", "leeto", -1)]
    [InlineData("aaa", "aaaa", -1)]
    [InlineData("bb", "bb", 0)]
    [InlineData("mississippi", "issipi", -1)]
    [InlineData("aaab", "b", 3)]
    [InlineData("aaabb", "bb", 3)]
    [InlineData("mississippi", "sippia", -1)]
    [InlineData("mississippi", "issip", 4)]
    public void Test(string haystack, string needle, int expected)
    {
        // Given
        // When
        var actual = FindTheIndexOfTheFirstOccurrenceInAString.Solution2(haystack, needle);
        // Then
        Assert.Equal(expected, actual);
    }
}
