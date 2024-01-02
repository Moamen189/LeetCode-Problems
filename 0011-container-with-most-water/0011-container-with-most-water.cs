public class Solution {
    public int MaxArea(int[] height) {
        int n = height.Length;
        int maxWater = 0;
        int left = 0, right = n - 1;

        while (left < right)
        {
            int h = Math.Min(height[left], height[right]);
            int w = right - left;
            maxWater = Math.Max(maxWater, h * w);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }

        return maxWater;
    }
}