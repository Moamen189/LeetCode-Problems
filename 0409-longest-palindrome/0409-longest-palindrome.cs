public class Solution {
    public int LongestPalindrome(string s) {
        
        if (s == null || s.Length == null)
            return 0;
        
        int len = 0;
         HashSet<char> set = new HashSet<char>();
        
        foreach (char c in s){
            
            if (set.Contains(c)){
                
                len += 2;
                set.Remove(c);
            }else{
                set.Add(c);
            }
                
            
        }
        
        return set.Count > 0 ? len +1  : len;
        

        
    }
}