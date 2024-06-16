public class Solution 
{
    public int LongestCommonSubsequence(string text1, string text2) 
    {
        int n = text1.Length, m = text2.Length;
        int[,] DP = new int[n+1, m+1];

        for (int j = 0; j < m+1; j++) DP[0, j] = 0;

        for (int i = 1; i < n+1; i++) DP[i, 0] = 0;

        for (int i = 1; i < n+1; i++)
        {
            for (int j = 1; j < m+1; j++)
            {
                if (text1[i-1] == text2[j-1])
                    DP[i, j] = 1 + DP[i-1, j-1];
                else
                    DP[i, j] = Math.Max(DP[i-1, j], DP[i, j-1]);
            }
        }
        return DP[n, m];
    }
}