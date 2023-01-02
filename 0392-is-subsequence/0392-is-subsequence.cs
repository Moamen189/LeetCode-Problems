public class Solution {
    public bool IsSubsequence(string s, string t) {
        int indexS = 0;
        for (int indexT =0; indexS < s.Length && indexT <  t.Length;  indexT++){
            if(s[indexS] == t[indexT])
                indexS ++; 
        }
        
        return indexS == s.Length ? true : false;
        
    }
}