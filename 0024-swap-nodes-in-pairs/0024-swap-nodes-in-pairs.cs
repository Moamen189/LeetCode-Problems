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
    public ListNode SwapPairs(ListNode head) {
        if (head == null) return null;

	ListNode res = new ListNode();
	res.next = head;
	ListNode prev = res;

	while (prev.next != null && prev.next.next != null)
	{
		ListNode l1 = prev.next;
		ListNode l2 = prev.next.next;

		l1.next = l2.next;
		l2.next = l1;

		prev.next = l2;
		prev = l1;
	}

	return res.next;
    }
}