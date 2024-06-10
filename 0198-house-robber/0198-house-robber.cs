public class Solution {
public int Rob(int[] nums) {
        if(nums == null || nums.Length == 0)
        {
            return 0;
        }
        
        int firstPrevious = 0;
        int secondPrevious = 0;
        int current = 0;
                        
        for(int i = 0; i < nums.Length; i++)
        {
            secondPrevious = firstPrevious;
            firstPrevious = current;
            current = Math.Max(firstPrevious, secondPrevious + nums[i]);
        }
    return current;
        
}
}