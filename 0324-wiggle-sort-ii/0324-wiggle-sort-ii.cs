public class Solution 
{
    public void WiggleSort(int[] nums) 
    {
        if(nums==null || nums.Length==0)
            return;
        int[] temp = new int[nums.Length];
        Array.Copy(nums,temp,nums.Length);
        Array.Sort(temp);
        
        int mid = (nums.Length-1)/2;
        int end = nums.Length-1;
       
        for(int i=0;i<nums.Length;i++)
        {
            if(i%2==0)
                nums[i] = temp[mid--];
            else
                nums[i] = temp[end--];
        }
    }
}