public class Solution {
    public string MakeFancyString(string s) {
        if (s.Length < 3) return s;
        var newS = new StringBuilder();
        
        newS.Append(s[0]);
        newS.Append(s[1]);
        
        for(int i = 2; i < s.Length; i++){
            if(!(s[i] == s[i-1] && s[i] == s[i-2])){
                newS.Append(s[i]);
            }
        }
        
        return newS.ToString();

        
    }
}