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
        decimal count = 0;
        var curr = head;
        while (curr != null)
        {
            count++;
            curr = curr.next;
        }

        decimal middle = decimal.Zero;

        if (count % 2 == 1)
        {
            middle = Math.Ceiling(count / 2);
        }
        else
        {
            middle = Math.Ceiling(count / 2) + 1;
        }

        count = 1;
        curr = head;
        while (curr != null)
        {
            if (middle == count)
            {
                return curr;
            }
            count++;
            curr = curr.next;
        }

        return new ListNode();
    }
}
