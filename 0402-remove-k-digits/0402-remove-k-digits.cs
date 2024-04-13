public class Solution {
    public string RemoveKdigits(string num, int k) 
    {
        if(num==null || num.Length==0)
            return num;
        
        Stack<char> st = new Stack<char>();
        
        foreach(var ch in num)
        {
            while(st.Count > 0 && k > 0 && ch < st.Peek())
            {
                st.Pop();
                k--;
            }
            st.Push(ch);
        }
        
        while(st.Count > 0 && k > 0)
        {
            st.Pop();
            k--;
        }
        
        StringBuilder sb = new StringBuilder();
        foreach(var item in st)
            sb.Append(item);
        
        char[] arr = sb.ToString().ToCharArray();
        Array.Reverse(arr);
        string ans = new String(arr).TrimStart('0');
        return ans == "" ? "0" : ans;
    }
}