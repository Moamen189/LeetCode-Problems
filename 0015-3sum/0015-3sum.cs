public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        List<IList<int>> res = new List<IList<int>>();
        if(nums == null || nums.Length < 3)
            return res;
        
        Array.Sort(nums);
        for(int i = 0; i < nums.Length - 2; i++)
        {

            if(nums[i] > 0 || (i > 0 && nums[i] == nums[i-1]))
                continue;
            
            int left = i + 1, right = nums.Length -1;
            while(left < right)
            {
                if(nums[i] + nums[left] + nums[right] == 0)
                {
                    res.Add(new List<int>(){nums[i], nums[left], nums[right]});
                    left++;
                    right--;
                    
                    while(left < right && nums[left] == nums[left-1])
                        left++;
                    while(left < right && nums[right] == nums[right+1])
                        right--;
                }
                else if(nums[i] + nums[left] + nums[right] > 0)
                    right--;
                else
                    left++;
            }
        }
        
        return res;
    }
}