public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        
        if(nums == null || k==0)
            return 0;
        double sum = 0;
        for(int i =0; i < k; i++){
            sum += nums[i];   
        }
        
        double avg = sum / k;
            
        for (int i =k; i < nums.Length; i++){
            sum += nums[i] - nums[i-k];
            avg = Math.Max(avg, sum/k);
        }
        
        return avg;

    }
}