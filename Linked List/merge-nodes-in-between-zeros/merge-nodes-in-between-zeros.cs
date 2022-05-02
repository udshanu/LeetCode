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
    public ListNode MergeNodes(ListNode head) {
        int sum = 0;

        if (head.val == 0)
        {
            head = head.next;
        }

        ListNode output = head;
        ListNode current = head;

        while (current != null)
        {
            if (current.val == 0)
            {
                output.val = sum;
                output.next = current.next;
                current = output.next;
                output = output.next;

                sum = 0;
            }
            else
            {
                sum += current.val;
                current = current.next;
            }
        }

        return head;
    }
}
