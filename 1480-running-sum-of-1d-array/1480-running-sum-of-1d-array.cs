public class Solution {
    public int[] RunningSum(int[] nums) {
           int sum =0;
        for (int i =0; i < nums.Length; i++){
            nums[i]+=sum;
            sum = nums[i];
        }
        return nums;
        
    }
}