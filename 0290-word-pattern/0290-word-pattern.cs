public class Solution {
    public bool WordPattern(string pattern, string str) {
        string[] s = str.Split(' ');
        if(s.Length != pattern.Length)
            return false;
        Dictionary<char, string> d1 = new(); //store (pattern, str) key value pair
        Dictionary<string, char> d2 = new(); //store (str, pattern) key value pair
        
        for(int i = 0; i < s.Length; i++)
        {
            char c = pattern[i];
            if(!d1.ContainsKey(c) && !d2.ContainsKey(s[i])) //if not in both, add to both
            {
                d1.Add(c, s[i]);
                d2.Add(s[i], c);
            }
            else if(d1.ContainsKey(c) && d1[c] == s[i] && d2.ContainsKey(s[i]) && d2[s[i]] == c) //if both key value pair matches, we're good
                continue;
            else //Something wrong. Exit with false
                return false;
        }
        
        return true; //all patterns match
    }
}