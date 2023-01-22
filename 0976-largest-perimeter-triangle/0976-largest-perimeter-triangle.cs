public class Solution {
    public int LargestPerimeter(int[] nums) {
         Array.Sort(nums);
        int len = nums.Length;
        int index = nums.Length - 3;
        while (index >=0 ) {
            if (nums[index] + nums[index+1] > nums[index+2])
                break;
            index--;
        }
        if (index == -1) 
            return 0;
        return nums[index] + nums[index+1] + nums[index+2];
        
    }
}