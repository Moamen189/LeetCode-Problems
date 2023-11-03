public class Solution 
{
    public string LongestPalindrome(string s) 
    {
        var result = string.Empty;
        for(int i = 0; i < s.Length; i++)
        {
            var longestPalindrome = FindLongest
                (
                    FindPalindrome(s, i, i),
                    FindPalindrome(s, i, i+1)
                );
            
            if(longestPalindrome.Length > result.Length)
                result = longestPalindrome;
        }

        return result;
    }

    private string FindLongest(string s1, string s2)
    {
        if(s1.Length > s2.Length)
            return s1;
        else
            return s2;
    }

    private string FindPalindrome(string s, int l, int r)
    {
        int left = l, right = r;

        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }

        return s.Substring(left + 1, right - left - 1);
    }
}