public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> hashSet = new HashSet<int>(nums);
        hashSet.CopyTo(nums);
        return hashSet.Count;
    }
}