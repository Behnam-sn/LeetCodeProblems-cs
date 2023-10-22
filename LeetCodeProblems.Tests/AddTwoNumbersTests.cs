namespace LeetCodeProblems.Tests;

public class AddTwoNumbersTests
{
    private readonly AddTwoNumbers sut;

    public AddTwoNumbersTests()
    {
        sut = new();
    }

    [Fact]
    public void Test1()
    {
        // Given
        var l1 = Utils.StringToListNode("243");
        var l2 = Utils.StringToListNode("564");
        // When
        var result = sut.Solution(l1, l2);
        var expected = "708";
        // Then
        Assert.Equal(expected, Utils.ListNodeToString(result));
    }

    [Fact]
    public void Test2()
    {
        // Given
        var l1 = Utils.StringToListNode("0");
        var l2 = Utils.StringToListNode("0");
        // When
        var result = sut.Solution(l1, l2);
        var expected = "0";
        // Then
        Assert.Equal(expected, Utils.ListNodeToString(result));
    }

    [Fact]
    public void Test3()
    {
        // Given
        var l1 = Utils.StringToListNode("9999999");
        var l2 = Utils.StringToListNode("9999");
        // When
        var result = sut.Solution(l1, l2);
        var expected = "89990001";
        // Then
        Assert.Equal(expected, Utils.ListNodeToString(result));
    }
}