/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root==null)
        return root;
        Console.WriteLine(root.val+" "+p.val+" "+q.val);
      
        var left=LowestCommonAncestor(root.left,p,q);
        if(left!=null)
        return left;
        var right= LowestCommonAncestor(root.right,p,q);
         if(right!=null)
        return right;
        
        if(FindLCA(root,p) && FindLCA(root,q))
        return root;
        return null;
        
    }
    bool FindLCA(TreeNode node,TreeNode k)
    {
        if(node==null)
        return false;
        if(node.val==k.val)
        return true;
        return FindLCA(node.left,k)||FindLCA(node.right,k);
    }
}