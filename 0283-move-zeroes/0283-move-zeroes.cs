public class Solution {
    public void MoveZeroes(int[] nums) {
        	var n = nums.Length;


	for (var i = n - 2; i >= 0; i--)
	{
		if (nums[i] != 0) continue;

		for (var j = i; j < n - 1; j++)
		{
			if (nums[j + 1] == 0) break;

			var tmp = nums[j];
			nums[j] = nums[j + 1];
			nums[j + 1] = tmp;
		}
	}
    }
}