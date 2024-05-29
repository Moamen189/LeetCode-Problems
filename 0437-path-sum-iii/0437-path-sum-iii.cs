/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int PathSum(TreeNode root, int targetSum) {
        Dictionary<long, int> d = new Dictionary<long, int>();
        d[0] = 1;
        
        int ans = 0;
        Solve(root, 0);
        return ans;
        
        void Solve(TreeNode node, long runningSum) {
            if (node == null) return;
            
            runningSum += node.val;
            if (d.TryGetValue(runningSum - targetSum, out var c)) ans += c;
            
            if (!d.ContainsKey(runningSum)) d[runningSum] = 0;
            d[runningSum]++;
            
            Solve(node.left, runningSum);
            Solve(node.right, runningSum);
            
            d[runningSum]--;
        }
    }
}