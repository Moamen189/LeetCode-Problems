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
    public int GetDecimalValue(ListNode head) {
        StringBuilder builder = new StringBuilder();
        
        while(head!=null)
        {
            builder.Append(head.val);
            head = head.next;
        }
        
        return Convert.ToInt32(builder.ToString(),2);
    }
}