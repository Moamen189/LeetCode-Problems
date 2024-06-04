public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1, right = piles.Max();
        int result = right;
        while (left <= right)
        {
            int hour = 0, mid = (right - left) / 2 + left;

            foreach(var item in piles)
               hour += (int)Math.Ceiling(item * 1.0/ mid);
            if (hour < 0) break;
            if (hour <= h)
            {
                result = Math.Min(mid, result);
                right = mid - 1;
            }
            else left = mid + 1;
        }
        return result;
    }
}