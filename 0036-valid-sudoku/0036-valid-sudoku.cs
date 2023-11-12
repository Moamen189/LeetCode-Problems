public class Solution {
    public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j].CompareTo('.') != 0)
                    {
                        for (int k = i + 1; k < board.Length; k++)
                        {
                            if (board[i][j] == board[k][j])
                                return false;
                        }
                        for (int k = j + 1; k < board[0].Length; k++)
                        {
                            if (board[i][j] == board[i][k])
                                return false;
                        }
                        int toprow = (i / 3) * 3;
                        int laftcolumn = (j / 3) * 3;
                        for (int ii = 0; ii < 3; ii++)
                        {
                            for (int jj = 0; jj < 3; jj++)
                            {
                                if (i != toprow + ii && j != laftcolumn + jj)
                                    if (board[i][j] == board[toprow + ii][laftcolumn + jj])
                                        return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
}