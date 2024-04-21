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
    public int PairSum(ListNode head) {
        Stack<int> stack = new Stack<int>();
        Queue<int> queue = new Queue<int>();

        while(head != null)
        {
            stack.Push(head.val);
            queue.Enqueue(head.val);
            head = head.next;
        }
        int count = stack.Count;
        int i = 1;
        int j = count;
        int maxSum = 0;
        int num1 = 0;
        int num2 = 0;

        while (i <= (count / 2))
        {
            num1 = queue.Dequeue();
            num2 = stack.Pop();

            if ( num1 + num2 > maxSum)
            {
                maxSum = num1 + num2;
            }
            i++;
        }

        return maxSum;
    }
}