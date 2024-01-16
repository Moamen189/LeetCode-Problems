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

        // Traverse the left subtree
        PostorderTraversalHelper(node.left, result);

        // Traverse the right subtree
        PostorderTraversalHelper(node.right, result);

        // Visit the root node
        result.Add(node.val);
    }
}