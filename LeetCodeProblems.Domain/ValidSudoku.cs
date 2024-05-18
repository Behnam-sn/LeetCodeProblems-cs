namespace LeetCodeProblems.Domain;

public class ValidSudoku
{
    public bool Solution(char[][] board)
    {
        for (int x = 0; x < 9; x++)
        {
            var hashSet = new HashSet<char>();

            for (int y = 0; y < 9; y++)
            {
                var cell = board[x][y];

                if (cell == '.')
                {
                    continue;
                }

                if (hashSet.Contains(cell) == true)
                {
                    return false;
                }

                hashSet.Add(cell);
            }
        }

        for (int y = 0; y < 9; y++)
        {
            var hashSet = new HashSet<char>();

            for (int x = 0; x < 9; x++)
            {
                var cell = board[y][x];

                if (cell == '.')
                {
                    continue;
                }

                if (hashSet.Contains(cell) == true)
                {
                    return false;
                }

                hashSet.Add(cell);
            }
        }

        return true;
    }
}