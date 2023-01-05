public class Solution {
    public int MaxProfit(int[] prices) {
        
        if (prices.Length == 1)
            return 0;
        
        int Max = prices[0];
        int Min = prices[0];
        
        int res= 0;
        
        for(int i = 0; i < prices.Length-1 ; i++){
            
            if(prices[i] > prices[i+1]){
                Max =  0;
            }
            
            Max = Math.Max(Max , prices[i+1]);
            Min = Math.Min(Min , prices[i+1]);
            
            if (res < Max - Min){
                res = Max - Min;
            }
        }
        
        return res;

        
    }
}