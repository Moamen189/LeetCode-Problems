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
         private void Helper(TreeNode current, ref int sum, bool isLeft)
        {
            if (current.left == null && current.right == null && isLeft)
            {
                sum += current.val;
                return;
            }

            if (current.left != null)
            {
                Helper(current.left, ref sum, true);
            }

            if (current.right != null)
            {
                Helper(current.right, ref sum, false);
            }
        }


        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            if(root == null)
            {
                return 0;
            }
            Helper(root, ref sum, false);
            return sum;
        }
}