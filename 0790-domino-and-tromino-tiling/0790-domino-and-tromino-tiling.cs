public class Solution {
    public int NumTilings(int n) {
        int mod = (int)(1e9 + 7);
        long[] dp = new long[n+3];
        dp[1] = 1;
        dp[2] = 2;
        dp[3] = 5;

        for(int i=4; i<=n; i++) {
            dp[i] = (dp[i-1] * 2 + dp[i-3]) % mod;
        }

        return (int)dp[n];
    }
}