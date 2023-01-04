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
    public ListNode MiddleNode(ListNode head) {
        
        int middle = 0; 
        int NCount =0;
        
        ListNode newNode = head;
        
        while(head != null){
            head = head.next;
            NCount ++;
            
        }
        
        middle = NCount /2;
        
        for (int i =0; i < middle; i++){
            newNode = newNode.next;
        }
        return newNode;
        
        
        
    }
}