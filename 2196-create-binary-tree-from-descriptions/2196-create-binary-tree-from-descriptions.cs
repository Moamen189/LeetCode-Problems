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
public TreeNode CreateBinaryTree(int[][] descriptions) {
	var dict = new Dictionary<int, TreeNode>();
	foreach (var n in descriptions.SelectMany(desc => desc[0..2])) {
		if (!dict.ContainsKey(n)) {
			dict[n] = new TreeNode(n);
		}
	}
	foreach (var desc in descriptions) {
		if (desc[2] == 1) {
			dict[desc[0]].left = dict[desc[1]];
		} else {
			dict[desc[0]].right = dict[desc[1]];
		}
	}
	var parents = descriptions.Select(desc => desc[0]).Distinct();
	var children = descriptions.Select(desc => desc[1]).ToHashSet();
	var root = parents.Single(parent => !children.Contains(parent));
	return dict[root];
}
}