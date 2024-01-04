public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        
        if (root == null) return result;

        var stack = new Stack<TreeNode>();
        var cur = root;

        while (cur != null) {
            stack.Push(cur);
            cur = cur.left;
        }

        while (stack.Any()) {
            cur = stack.Pop();
            result.Add(cur.val);

            if (cur.right != null) {
                cur = cur.right;

                while (cur != null) {
                    stack.Push(cur);
                    cur = cur.left;
                }
            }
        }

        return result;
    }
}