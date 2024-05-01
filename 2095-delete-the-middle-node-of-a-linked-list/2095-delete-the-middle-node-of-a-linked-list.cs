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
    public ListNode DeleteMiddle(ListNode head) {
         ListNode slow = head;
            ListNode fast = head;

            while (fast.next != null && fast.next.next !=null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            if (slow == fast && slow.next==null) return null;
            if (fast.next == null)
            {
                slow.val = slow.next.val;
            }
            slow.next = slow.next.next;

            return head;
    }
}