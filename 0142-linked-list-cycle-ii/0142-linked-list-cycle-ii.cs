/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var hashS = new HashSet<ListNode>();
        
        var Nodes = head;
        
        while (Nodes != null){
            
            if (!hashS.Add(Nodes))
                 return Nodes;
            Nodes = Nodes.next;
               
            
            
                
            
        }
        
        return null;
        
    }
}