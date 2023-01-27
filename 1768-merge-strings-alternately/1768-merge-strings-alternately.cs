public class Solution {
    public string MergeAlternately(string word1, string word2) {
       int n = Math.Max(word1.Length, word2.Length);
        int p = 0;
        var sb = new StringBuilder();
        while (p < n) {
            var l1 = p < word1.Length ? word1[p].ToString() : "";
            var l2 = p < word2.Length ? word2[p].ToString() : "";
            sb.Append(l1 + l2);
            p++;
        }
        return sb.ToString();
    }
}