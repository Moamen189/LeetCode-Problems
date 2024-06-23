public class Solution {
  public int EqualPairs(int[][] grid) {
        var n = grid.Length;
        var cols = new int[n];
        var rows = new int[n];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                rows[row] += grid[row][col];
                cols[col] += grid[row][col];
            }
        }
        var rs = 0;
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                if (rows[r] == cols[c])
                {
                    if (AreTheSame(r, c, grid)) rs++;
                }
            }
        }
        return rs;
    }
    private bool AreTheSame(int r, int c, int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            if (grid[r][i] != grid[i][c]) return false;
        }
        return true;
    }
}