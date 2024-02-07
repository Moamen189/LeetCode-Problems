public class Solution {
    public string CountAndSay(int n) {
        if(n <= 1) 
            return "1";
        
        string strResult = CountAndSay(n-1); 
        
        StringBuilder sb = new StringBuilder();
        int counter = 1;
        for(int idx = 1; idx <= strResult.Length; idx++)
        {
            if(idx < strResult.Length && strResult[idx] == strResult[idx-1])
                counter++;
            else
            {
                sb.Append(counter).Append(strResult[idx-1]); 
                counter = 1; 
            }
        }
        return sb.ToString();
    }
}