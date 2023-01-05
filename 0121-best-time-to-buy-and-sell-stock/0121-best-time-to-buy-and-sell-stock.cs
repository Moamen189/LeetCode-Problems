public class Solution {
    public int MaxProfit(int[] prices) {
         if(prices.Length == 1)
            return 0;
        
        int tempMax = prices[0];
        int tempMin = prices[0];
        int res = 0;

        for(int i=0; i< prices.Length-1; i++)
        {
            if(prices[i]>prices[i+1])
            {
                tempMax = 0;
            }
            
            tempMax = Math.Max(tempMax, prices[i+1]);
            tempMin = Math.Min(tempMin, prices[i+1]);
            
            if(res < tempMax-tempMin)
            {
                res = tempMax-tempMin;
            }
        }
        
        return res;
        
    }
}