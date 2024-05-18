namespace LeetCodeProblems.Tests;

public class AddTwoNumbersTests
{
    private readonly AddTwoNumbers sut = new();

    [Theory]
    [InlineData("243", "564", "708")]
    [InlineData("0", "0", "0")]
    [InlineData("9999999", "9999", "89990001")]
    public void Test_Pass(string number1, string number2, string expected)
    {
        // Given
        var listNode1 = Utils.StringToListNode(number1);
        var listNode2 = Utils.StringToListNode(number2);
        // When
        var result = sut.Solution(listNode1, listNode2);
        // Then
        var actual = Utils.ListNodeToString(result);
        Assert.Equal(expected, actual);
    }
}