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
    public IList<int> PostorderTraversal(TreeNode root) {
     List<int> result = new List<int>();
        PostorderTraversalHelper(root, result);
        return result;
    }

    private void PostorderTraversalHelper(TreeNode node, List<int> result)
    {
        if (node == null)
        {
            return;
        }

        PostorderTraversalHelper(node.left, result);


        PostorderTraversalHelper(node.right, result);

        result.Add(node.val);
    }
}