namespace LeetCodeProblems.Tests;

public class ValidSudokuTests
{
    private readonly ValidSudoku sut;

    public ValidSudokuTests()
    {
        sut = new();
    }

    [Fact]
    public void Test1()
    {
        // Given
        var board = new char[][]
        {
            new char[] {'5','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'},
        };
        // When
        var actual = sut.Solution(board);
        // Then
        Assert.True(actual);
    }
}