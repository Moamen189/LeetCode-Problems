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
        var slow= new HashSet<ListNode>();
        var fast= head;
        
        while(fast!=null)
        {
            if(!slow.Add(fast))
                return fast;
            
            
            fast=fast.next;
        }
        
        return null;
    }
}