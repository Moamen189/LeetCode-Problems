public class Solution {
    public int Reverse(int x) {
         var xStr = x.ToString();
        StringBuilder sb= new StringBuilder();
        int i =0;
        int res; 
        if(xStr[i] == '-')
        {
            i++;
            sb.Append("-");
        }
       for(int j = xStr.Length -1; j >=i ; j-- )
       {
           sb.Append(xStr[j]);
       }
       if(Int32.TryParse(sb.ToString() , out res))
       return res; 
        
        return 0; 
        
    }
}