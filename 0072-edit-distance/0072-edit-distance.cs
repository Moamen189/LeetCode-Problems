public class Solution {
    public int MinDistance(string word1, string word2) => LevenshteinDistance(word1.ToArray(), word2.ToArray());        
    public int LevenshteinDistance(char[] s1, char[] s2)
    {
        int s1p = s1.Length, s2p = s2.Length;
        int[,] num = new int[s1p + 1, s2p + 1];
        for (int i = 0; i <= s1p; i++)
            num[i,0] = i;
        for (int i = 0; i <= s2p; i++)
            num[0,i] = i;
        for (int i = 1; i <= s1p; i++)
            for (int j = 1; j <= s2p; j++)
                num[i,j] = Math.Min(Math.Min(num[i - 1,j] + 1,
                        num[i,j - 1] + 1), num[i - 1,j - 1]
                        + (s1[i - 1] == s2[j - 1] ? 0 : 1));
        return num[s1p,s2p];
    }
}