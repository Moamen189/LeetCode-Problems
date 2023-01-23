public class Solution {
    public int ArraySign(int[] nums) {
        int x =1;
        foreach (var num in nums){
           if (num == 0){
            return 0;
        }
            x*=num > 0 ? 1 : -1;
        }
        
     return x;
    }
}