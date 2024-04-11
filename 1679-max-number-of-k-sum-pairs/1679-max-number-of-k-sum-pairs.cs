public class Solution {
  public int MaxOperations(int[] nums, int k) {
        if(nums.Length < 2) return 0;
        Array.Sort(nums);
        int i = 0, j = nums.Length - 1, count = 0;

        while(i < j) {
            if(k - nums[i] == nums[j]) {
                count++;
                i++;
                j--;
            } else if( k - nums[i] > nums[j]) {
                i++;
            } else {
                j--;
            }
        }
        return count;
    }
}