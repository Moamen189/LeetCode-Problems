public class Solution {
     public bool BackspaceCompare(string s, string t) {
        return BuildStr(s).Equals(BuildStr(t));
    }
    
    public string BuildStr(string str)
    {
        var sb = new StringBuilder();
        
        foreach(var c in str)
        {
            if(c == '#')
            {
                if(sb.Length > 0)
                    sb.Length--;
            }
            else
            {
                sb.Append(c);
            }
        }
        
        return sb.ToString();
    }
}