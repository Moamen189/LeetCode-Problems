public class Solution {
    
    private int m;
    private int n;
    private int ans;
    private int[,] dp;
    
    public int MaximalRectangle(char[][] matrix) {

        (m, n, ans) = (matrix.Length, matrix[0].Length, 0);
        dp = new int[m, n];

        for(int i = 0; i < m; i++) {
            for(int j = 0; j < n; j++) {
                dp[i, j] = matrix[i][j] == '1' ? 1 + (j > 0 ? dp[i, j-1] : 0) : 0;  
            }
        }

        for(int i = m-1; i >= 0; i--) {
            for(int j = n-1; j >= 0; j--) {    
                Helper(i, j, dp[i, j], 1);
            }
        }

        return ans;
    }

    public void Helper(int i, int j, int min, int count) {
        
        if (i < 0 || j < 0 || i >= m || j >= n || dp[i, j] == 0)
            return;
        
        min = Math.Min(dp[i, j], min);
        ans = Math.Max(ans, min*count);

        Helper(i-1, j, min, count+1);
    }

}