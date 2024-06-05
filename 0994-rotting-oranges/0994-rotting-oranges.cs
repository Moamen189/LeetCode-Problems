public class Solution {
    public int OrangesRotting(int[][] grid) {
        int[,] direction = {{1,0},{-1,0},{0,1},{0,-1}};

        var height = grid.Length;
        var width = grid[0].Length;

        var map = new bool[height, width];

        var oranges = 0;
        var minutes = 0;
        var queue = new Queue<(int x, int y, int min)>();
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                if (grid[y][x] == 2)
                {
                    queue.Enqueue((x, y, 0));
                }
                else if(grid[y][x] == 1)
                {
                    oranges++;
                }
            }
        }

        while (queue.Any())
        {
            var coord = queue.Dequeue();
            if (grid[coord.y][coord.x] == 1)
            {
                coord.min++;
                oranges--;
                minutes = Math.Max(coord.min, minutes);
            }

            map[coord.y, coord.x] = true;

            for (var i = 0; i < 4; i++)
            {
                var x = coord.x + direction[i, 0];
                var y = coord.y + direction[i, 1];
                if (x >= 0 && x < width && y >= 0 && y < height && !map[y, x] && grid[y][x] != 0)
                {
                    queue.Enqueue((x, y, coord.min));
                    map[y, x] = true;
                }
            }
        }

        return oranges > 0 ? -1 : minutes;
    }
}