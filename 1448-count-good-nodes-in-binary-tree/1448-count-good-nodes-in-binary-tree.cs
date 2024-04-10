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
 public int GoodNodes(TreeNode root) {
        int maxVal = root.val;
        return GetGoodNodes(root,maxVal);
    }
    public int GetGoodNodes(TreeNode root, int maxVal){
        if(root == null)
            return 0 ;
        if(root.val>= maxVal){
            maxVal = root.val;
            return GetGoodNodes(root.right,maxVal) 
                    +GetGoodNodes(root.left,maxVal)+1;
        }
        else{
            return GetGoodNodes(root.left,maxVal)
                  + GetGoodNodes(root.right,maxVal);
        }
    }
}