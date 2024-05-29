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
    public int LongestZigZag(TreeNode root)
    {
        Queue<(TreeNode, string, int)> q = new Queue<(TreeNode, string, int)>();
        q.Enqueue((root, "", 0));
        int ans = 0;

        while (q.Count > 0)
        {
            (TreeNode u, string prevDir, int cnt) = q.Dequeue();
            ans = Math.Max(ans, cnt);

            if (u.left != null)
            {
                if (prevDir == "r")
                    q.Enqueue((u.left, "l", cnt + 1));
                else
                    q.Enqueue((u.left, "l", 1));
            }

            if (u.right != null)
            {
                if (prevDir == "l")
                    q.Enqueue((u.right, "r", cnt + 1));
                else
                    q.Enqueue((u.right, "r", 1));
            }
        }

        return ans;
    }
}