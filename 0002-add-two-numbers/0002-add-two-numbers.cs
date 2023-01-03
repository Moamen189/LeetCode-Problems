/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
         int carry = 0;
        ListNode dummy = new ListNode(0);
        ListNode head = dummy;
        
        while(l1 != null || l2 != null || carry != 0)
        {
            int val1 = l1 == null? 0 : l1.val;
            int val2 = l2 == null? 0 : l2.val;
            int sum = val1 + val2 + carry; 
            
            dummy.next = new ListNode(sum % 10);
            dummy = dummy.next;
            carry = sum / 10;            
            
            l1 = l1 == null? null : l1.next;
            l2 = l2 == null? null : l2.next;
        }      
        
        return head.next;
    }
    
}