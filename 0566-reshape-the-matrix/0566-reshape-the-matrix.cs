public class Solution {
    public int[][] MatrixReshape(int[][] mat, int r, int c) {
        if (r * c != mat.Length * mat[0].Length)
            return mat;
        int[][] result = new int[r][];
        int row = 0;
        int column = 0;
        result[row] = new int[c];
        for(int i = 0; i < mat.Length; i++){
            for (int j = 0; j < mat[i].Length; j++){
                if (column == c){
                    row++;
                    result[row] = new int[c];
                    column = 0;
                }
                result[row][column++] = mat[i][j];
            }
        }
        return result;
    }
}