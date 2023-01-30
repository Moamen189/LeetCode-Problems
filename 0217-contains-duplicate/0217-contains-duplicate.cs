public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        	var set = new HashSet<int>();

	        return nums.Any(x => !set.Add(x));
    }
}