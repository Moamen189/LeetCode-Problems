public class Solution {
    public int LengthOfLongestSubstring(string s) {
            if(String.IsNullOrEmpty(s))
        {
            return 0;
        }
        var freq = new Dictionary<char, int>();
        int count = 0;
        int begin = 0;
        int end = 0;
        int res = 0;
        while ( end < s.Length)
        {
            if(!freq.ContainsKey(s[end]))
            {
                freq[s[end]] = 0;
            }
            if(++freq[s[end++]] > 1)
            {
                count++;
            } 
            while(count == 1)
            {
                 if(--freq[s[begin++]] == 1)
                {
                    count--;
                }
            }
            res = Math.Max(res, end - begin);
        }
        return res;
        
    }
}