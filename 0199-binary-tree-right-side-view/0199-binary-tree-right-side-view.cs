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
public IList<int> RightSideView(TreeNode root)
        {
            Dictionary<int, List<int>> nodes = new Dictionary<int, List<int>>();
            DFS(root, nodes, 0);

            List<int> ans = new List<int>();
            foreach (var row in nodes.Values)
            {
                ans.Add(row.Last());
            }
            return ans;
        }

        private void DFS(TreeNode root, Dictionary<int, List<int>> nodes, int depth)
        {
            if (root == null)
            {
                return;
            }

            if (!nodes.ContainsKey(depth))
            {
                nodes.Add(depth, new List<int>());
            }

            nodes[depth].Add(root.val);

            DFS(root.left, nodes, depth + 1);
            DFS(root.right, nodes, depth + 1);
        }
}