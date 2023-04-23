public class Solution {
    public int StrStr(string haystack, string needle) {
        int haystackLen = haystack.Length;
        int needleLen = needle.Length;
        if(needleLen == 0 ) return 0;
        if(needleLen > haystackLen) return -1;
        
        for(int i=0; i<haystackLen-needleLen+1; i++){
            if(haystack.Substring(i, needleLen) == needle){
                return i;
            }
        }
        
        return -1;
    }
}