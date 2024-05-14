public class Solution 
{
        
    public int MinFlips(int a, int b, int c) 
    {
        var aOrb = a | b;
        var aAndb = a & b;
        var count = 0;
        for(var abc= aOrb ^ c; abc != 0; abc >>= 1)
        {			
            if((abc & 1) == 1)
            {                
                if ((c & 1) == 0)
                {
                    if((aAndb & 1) == 1)
                        count += 2;
                    else
                        count ++;
                    
                }else
                {
                    count++;
                }                
            }
            
            aAndb >>=1;
            c >>= 1;            
        }
        
        return count;
    }
}