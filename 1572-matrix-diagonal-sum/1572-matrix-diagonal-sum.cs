public class Solution {
    public int DiagonalSum(int[][] array) {
         int sum = 0;
        for(int i = 0; i < array.Length; i++) {
            for(int j = 0; j < array.Length; j++) {
                if(i == j) {
                    sum += array[i][j];
                }
                if(j == array.Length - (i + 1) && j != i) {
                    sum += array[i][array.Length - (i + 1)];
                }
            }
        }
        return sum;
    }
}