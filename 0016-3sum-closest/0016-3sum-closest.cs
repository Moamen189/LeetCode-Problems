public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
  Array.Sort(nums);
            int result = int.MaxValue;
            int diff = int.MaxValue;
            for (int i = 0; i < nums.Length-2; i++)
            {
                int j = i + 1;
                int k = nums.Length - 1;

                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];

                    if(Math.Abs(diff) > Math.Abs(sum - target))
                    {
                        diff = sum - target;
                        result = sum;
                    }

                    if (sum < target)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }
            return result;
        }
}