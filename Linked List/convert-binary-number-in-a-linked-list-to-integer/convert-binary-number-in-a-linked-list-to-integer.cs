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
        double count = 0;
        ListNode curr = head;
        while (curr != null)
        {
            count++;
            curr = curr.next;
        }

        double result = 0;
        curr = head;
        while (curr != null)
        {
            if (curr.val == 1)
            {
                result += Math.Pow(2, count - 1);
            }
            else
            {
                curr = curr.next;
                count--;
                continue;
            }

            curr = curr.next;
            count--;
        }

        return (int)result;
    }
}
