public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
         (int previous, int current) = (cost[0], cost[1]);

        for (int index = 2; index < cost.Length; index++)
        {
            (previous, current) = (current, cost[index] + Math.Min(previous, current));
        }

        return Math.Min(previous, current);
    }
}