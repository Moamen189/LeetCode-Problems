/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        var p1 = headA;
        var p2 = headB;

        if (p1 == null || p2 == null) return null;

        while (p1 != null && p2 != null && p1 != p2) {
            p1 = p1.next;
            p2 = p2.next;

            if (p1 == p2) return p1;

            if (p1 == null) p1 = headB;
            if (p2 == null) p2 = headA;
        }

        return p1;        

    }
}