public class Solution {
    public int SingleNumber(int[] nums) {
        int x = 0;
        foreach(int num in nums){
            x ^= num;
        }
        return x;
    }
}