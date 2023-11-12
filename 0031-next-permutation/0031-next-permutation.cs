public class Solution {
    public void NextPermutation(int[] nums) {
        
        int pre = nums[nums.Length-1];
        int i =nums.Length-2;
        for(; i>=0; i--)
        {            
            if(nums[i]<pre) break;
            pre = nums[i];
        }
        if(i==-1)
        {   
            revert(nums,0,nums.Length-1);
            return;
        }        
        int j=nums.Length-1;
        for(; j>i; j-- )
        {
            if(nums[j]>nums[i]) break;
        }
        int t = nums[j];
        nums[j] = nums[i];
        nums[i] = t; 
        revert(nums,i+1,nums.Length-1);
    }    
    void revert(int[] nums, int a, int b) 
    {
        while(a<b)
        {
            int tt = nums[a];
            nums[a] = nums[b];
            nums[b] = tt;
            a++;b--;
        }                   
    }
        
}