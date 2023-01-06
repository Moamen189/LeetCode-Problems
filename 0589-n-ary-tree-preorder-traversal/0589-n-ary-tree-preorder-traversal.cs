/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    private IList<int> result = new List<int>();
    public IList<int> Preorder(Node root) {
        if(root!=null)
        {
            result.Add(root.val);
            foreach(Node n in root.children)
                Preorder(n);
        }
        return result;
    }
}