public class Solution {
    public int LongestSubarray(int[] nums) {
        int res = 0, left = 0, del = 0;
        for (int right = 0; right < nums.Length; right++)
        {
            del += nums[right] == 0 ? 1 : 0;
            if (del <= 1)
                res = Math.Max(res, right - left + 1);
            else
            {
                del -= nums[left] == 0 ? 1 : 0;
                left++;
            }
        }
        return --res;
    }
}