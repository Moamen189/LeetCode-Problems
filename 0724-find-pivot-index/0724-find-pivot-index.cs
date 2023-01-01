public class Solution {
    public int PivotIndex(int[] nums) {
        if (nums == null || nums.Length == 0)
                return -1;

            int[] leftToRight = new int[nums.Length],
                  rightToLeft = new int[nums.Length];

            leftToRight[0] = nums[0];
            rightToLeft[nums.Length - 1] = nums[nums.Length - 1];

            for (int i = nums.Length - 2; i > -1; i--)
                rightToLeft[i] = rightToLeft[i + 1] + nums[i];

            if (leftToRight[0] == rightToLeft[0])
                return 0;
            
            for (int i = 1; i < nums.Length; i++)
            {
                leftToRight[i] = leftToRight[i - 1] + nums[i];

                if (leftToRight[i] == rightToLeft[i])
                    return i;
            }
            
            return -1;
        
    }
}