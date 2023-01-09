public class Solution {
    public int NumIslands(char[][] grid) {
         if (grid == null || grid.Length == 0)
            return 0;

        var counter = 0;
        var yMax = grid.Length;
        var xMax = grid[0].Length;

        for (var y = 0; y < yMax; y++)
        for (var x = 0; x < xMax; x++)
            if (grid[y][x] == '1') {
                TraversIsland(x, y);
                counter++;
            }

        return counter;

        void TraversIsland(int x, int y) {
            if (x < 0 || x >= xMax || y < 0 || y >= yMax || grid[y][x] != '1')
                return;

            grid[y][x] = '0';
            TraversIsland(x, y + 1);
            TraversIsland(x, y - 1);
            TraversIsland(x + 1, y);
            TraversIsland(x - 1, y);
        }
    }
}