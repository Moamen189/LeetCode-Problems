public class Solution {
    public int MinDistance(string text1, string text2)
    {
        int t1Length = text1.Length, t2Length = text2.Length;
        var dp = new int[t1Length + 1, t2Length + 1];
        foreach (var i in Enumerable.Range(0, t1Length + 1))
        {
            foreach (var j in Enumerable.Range(0, t2Length + 1))
            {
                if (i == 0 && j == 0) dp[i, j] = 0;
                else if (i == 0) dp[i, j] = dp[i, j - 1] + 1;
                else if (j == 0) dp[i, j] = dp[i - 1, j] + 1;
                else if (text1[i - 1] == text2[j - 1]) dp[i, j] = dp[i - 1, j - 1];
                else
                {
                    var minInherited = (new int[] { dp[i - 1, j - 1], dp[i - 1, j], dp[i, j - 1] }.Min());
                    dp[i, j] = 1+ minInherited;
                }
            }
        }
        return dp[t1Length, t2Length];
    }
}