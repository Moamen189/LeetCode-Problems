public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int i = nums.ToList().BinarySearch(target);
        return i >= 0 ? i: ~i;
    }
}