public class Solution 
{
    public string DecodeString(string s) 
    {
        var str = recur(s, 0);
        return str.Item1;
    }
    
    public (string, int) recur(string s, int index)
    {
        if(index >= s.Length)
            return ("", 0);
        
        var sb = new StringBuilder();
        var num = new StringBuilder();
        int repeat = 0;
        for(int i = index; i<s.Length; i++)
        {
            if(char.IsDigit(s[i]))
            {
                while(char.IsDigit(s[i]) && i < s.Length)
                {
                    num.Append(s[i]);
                    i++;
                }
                
                i--;
                repeat = int.Parse(num.ToString());
                num.Clear();
            }
            else if(s[i] == '[')
            {
                var str = recur(s, i+1);
                
                for(int r = 0; r < repeat; r++)
                {
                    sb.Append(str.Item1);
                }
                
                i = str.Item2-1;
            }
            else if(s[i] == ']')
                return (sb.ToString(), i+1);
            else
                sb.Append(s[i]);
        }
        
        return (sb.ToString(), s.Length);
    }
}