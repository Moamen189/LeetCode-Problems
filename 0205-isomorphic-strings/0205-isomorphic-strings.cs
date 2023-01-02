public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if (s.Length != t.Length)
            return false;
        
        Dictionary<char,char> dic = new Dictionary<char,char>();
        for (int i = 0; i < s.Length; i++ ){
            if (dic.ContainsKey(s[i]))
            {
                if(dic[s[i]] != t[i])
                    return false; 
               
             }
            else{
                if(dic.ContainsValue(t[i]))
                    return false; 
                    else
                        dic.Add(s[i] , t[i]);
            }
                
            
        }
        return true;
        
    }
}