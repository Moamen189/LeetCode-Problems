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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        return getValue(root1).Equals(getValue(root2));
    }

    public string getValue(TreeNode t){
        string result = "";

        if(t.left == null && t.right == null){
            return " " + t.val;
        }
        if (t.left != null){
            result += "" + getValue(t.left);
        }
        if(t.right != null){
            result += "" + getValue(t.right);
        }

        return result;
    }
}