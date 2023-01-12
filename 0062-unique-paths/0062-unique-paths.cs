public class Solution {
    public int UniquePaths(int m, int n) {
        if (m == 0 && n == 0) return 0;
        
        var dp = new int[m];

        for (int j = 0; j < m; j++) {
            dp[j] = 1;
        }
        for (int i = 1; i < n; i++) {
			for (int j = 1; j < m; j++) {
                dp[j] = dp[j] + dp[j - 1];
            }
        }

        return dp[m - 1]; 
    }
}