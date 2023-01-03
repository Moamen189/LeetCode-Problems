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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        
        if (list1 == null)
            return list2;
        if (list2 == null)
            return list1;
        ListNode current;
        if (list1.val < list2.val)
        {
            current = list1;
            current.next = MergeTwoLists(list1.next , list2);
        }else {
            current = list2;
            current.next = MergeTwoLists(list1 , list2.next);
            
        }
        return current;
    }
}