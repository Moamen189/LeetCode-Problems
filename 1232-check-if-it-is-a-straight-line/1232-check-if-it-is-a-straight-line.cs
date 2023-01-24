public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        if (coordinates.GetLength(0) <= 2)
            return true;
        for (int i = 2; i < coordinates.GetLength(0); i++) {
            if ((coordinates[i][0]-coordinates[i-1][0])*
                    (coordinates[i-1][1]-coordinates[i-2][1]) !=
                    (coordinates[i-1][0]-coordinates[i-2][0])*
                    (coordinates[i][1]-coordinates[i-1][1])) {
                return false;
            }
        }
        return true;
    }
}