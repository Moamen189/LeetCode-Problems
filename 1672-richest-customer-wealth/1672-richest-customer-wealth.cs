public class Solution {
    public int MaximumWealth(int[][] accounts) {
         int maxWealth = 0;
        int sum = 0;
        for (int i = 0;   i < accounts.Length; i++) {
            sum = 0;
            foreach(int j in accounts[i]){
                sum = sum+j;
            }
            if(sum > maxWealth){
                maxWealth = sum ;
            }
        }
        return maxWealth;
    }
}