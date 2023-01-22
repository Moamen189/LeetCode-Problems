public class Solution {
    public int NearestValidPoint(int x, int y, int[][] points) {
         int nearestValidPoint = -1;

        int nearest = int.MaxValue;
        for (int i = 0; i < points.Length; i++)
        {
            if(points[i][0] == x || points[i][1] == y)
            {
                int current = (Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]));

                if(current < nearest)
                {
                    nearest = current;
                    nearestValidPoint = i;
                }
            }
        }

        return nearestValidPoint;
    }
}