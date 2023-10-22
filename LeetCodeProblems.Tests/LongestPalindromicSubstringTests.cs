namespace LeetCodeProblems.Tests;

public class LongestPalindromicSubstringTests
{
    private readonly LongestPalindromicSubstring sut;

    public LongestPalindromicSubstringTests()
    {
        sut = new();
    }

    [Fact]
    public void Test1()
    {
        // Given
        // When
        var actual = sut.Solution("a");
        // Then
        Assert.Equal("a", actual);
    }

    [Fact]
    public void Test2()
    {
        // Given
        // When
        var actual = sut.Solution("babad");
        // Then
        Assert.Contains(actual, new List<string> { "aba", "bab" });
    }

    [Fact]
    public void Test3()
    {
        // Given
        // When
        var actual = sut.Solution("cbbd");
        // Then
        Assert.Equal("bb", actual);
    }

    [Fact]
    public void Test4()
    {
        // Given
        var s = "abcd";
        // When
        var actual = sut.Solution(s);
        // Then
        Assert.Contains(actual, s);
    }

    [Fact]
    public void Test5()
    {
        // Given
        // When
        var actual = sut.Solution("");
        // Then
        Assert.Equal("", actual);
    }

    [Fact]
    public void Test6()
    {
        // Given
        // When
        var actual = sut.Solution("cbbbbd");
        // Then
        Assert.Equal("bbbb", actual);
    }
}