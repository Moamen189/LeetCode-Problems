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
     List<int> list=new List<int>();
    public IList<int> PreorderTraversal(TreeNode root) {
        if(root!=null){
            list.Add(root.val);
            PreorderTraversal( root.left);
            PreorderTraversal( root.right);
        }
        return list;
    }
}