public class Solution {
public bool IncreasingTriplet(int[] nums) {
        if(nums == null || nums.Length < 3)
            return false;
        
        int minimum = nums[0];
        int secondMinimum = int.MaxValue; 
        
        var length = nums.Length;
        for(int i = 1; i < length; i++ )
        {
            var current = nums[i];
            
            if(current > secondMinimum)
                return true; 
            
            if(current < minimum)
            {
                //secondMinimum = minimum;
                minimum = current; 
            }                      
            
            if(current > minimum)
            {
                secondMinimum = current < secondMinimum? current : secondMinimum;
            }                        
        }
        
        return false;
    }
}