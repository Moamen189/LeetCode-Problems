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
    public int MaxLevelSum(TreeNode root) {
        helper(root,0);
        int ret=0;
        int maxval=int.MinValue;
        for(int i=0;i<list.Count;i++)
        {
            if(list[i]>maxval)
            {
                ret=i;
                maxval=list[i];
            }
        }
        return ret+1;
    }
    void helper(TreeNode root,int lev)
    {
        if(root==null)
            return;
        if(lev==list.Count)
            list.Add(root.val);
        else
            list[lev]+=root.val;
        helper(root.left,lev+1);
        helper(root.right,lev+1);
    }
}