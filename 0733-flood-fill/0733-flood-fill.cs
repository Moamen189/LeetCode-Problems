public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        int oldColor = image[sr][sc];
        if (newColor == oldColor)
        {
            return image;
        }
        var stack = new Stack<(int, int)>();
        stack.Push((sr, sc));

        while (stack.Count > 0)
        {
            var point = stack.Pop();
            int r = point.Item1;
            int c = point.Item2;
            image[r][c] = newColor;
            if (r > 0 && image[r - 1][c] == oldColor)
            {
                stack.Push((r - 1, c));
            }
            if (c > 0 && image[r][c - 1] == oldColor)
            {
                stack.Push((r, c - 1));
            }
            if (r + 1 < image.Length && image[r + 1][c] == oldColor)
            {
                stack.Push((r + 1, c));
            }
            if (c + 1 < image[0].Length && image[r][c + 1] == oldColor)
            {
                stack.Push((r, c + 1));
            }
        }
        return image;
    }
}