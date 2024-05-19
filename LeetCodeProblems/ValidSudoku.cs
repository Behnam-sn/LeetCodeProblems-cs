namespace LeetCodeProblems;

public class ValidSudoku
{
    public static bool Solution(char[][] board)
    {
        var cols = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<(int, int), HashSet<char>>();

        for (var y = 0; y < 9; y++)
        {
            var row = new HashSet<char>();
            for (var x = 0; x < 9; x++)
            {
                if (!cols.ContainsKey(x))
                {
                    cols[x] = new HashSet<char>();
                }

                if (!squares.ContainsKey((y / 3, x / 3)))
                {
                    squares[(y / 3, x / 3)] = new HashSet<char>();
                }

                var cellValue = board[y][x];

                if (cellValue == '.')
                {
                    continue;
                }

                if (row.Contains(cellValue) ||
                    cols[x].Contains(cellValue) ||
                    squares[(y / 3, x / 3)].Contains(cellValue))
                {
                    return false;
                }

                row.Add(cellValue);
                cols[x].Add(cellValue);
                squares[(y / 3, x / 3)].Add(cellValue);
            }
        }

        return true;
    }

    public static bool Solution2(char[][] board)
    {
        var horizontal = new Dictionary<int, HashSet<char>>()
        {
            { 0, new HashSet<char>() },
            { 1, new HashSet<char>() },
            { 2, new HashSet<char>() },
            { 3, new HashSet<char>() },
            { 4, new HashSet<char>() },
            { 5, new HashSet<char>() },
            { 6, new HashSet<char>() },
            { 7, new HashSet<char>() },
            { 8, new HashSet<char>() },
        };

        for (int y = 0; y < 9; y++)
        {
            var vertical = new HashSet<char>();
            for (int x = 0; x < 9; x++)
            {
                var cellValue = board[y][x];

                if (cellValue == '.')
                {
                    continue;
                }

                if (vertical.Contains(cellValue) || horizontal[x].Contains(cellValue))
                {
                    return false;
                }

                vertical.Add(cellValue);
                horizontal[x].Add(cellValue);
            }
        }
        return true;
    }

    public static bool Solution3(char[][] board)
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