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
    public TreeNode DeleteNode(TreeNode root, int key) {
    var ptr=root;
    TreeNode prev=null;
        
        while(ptr!=null){
            if(ptr.val==key)
                break;
            
            prev=ptr;
            if(ptr.val>key)
                ptr=ptr.left;
            else
              ptr=ptr.right;  
        }
        
        if(ptr==null)
            return root;
        
        var isLeft = key<prev?.val;
        
        var left=ptr.left;
        var right=ptr.right;
        var rightToRearrange = ptr.left?.right;
        
        if(left!=null){
            ptr=left;
            if(right!=null){
             ptr.right=right;
             
                if(rightToRearrange!=null){
                while(right.left!=null)
                {
                    right=right.left;
                }
             
                right.left=rightToRearrange;}
            }
        }
        else{
            ptr=right;
        }
        
        if(prev==null)
            root=ptr;
        else
        {
            if(isLeft)
                prev.left=ptr;
            else
                prev.right=ptr;
        }
        
        return root;
    }
}
