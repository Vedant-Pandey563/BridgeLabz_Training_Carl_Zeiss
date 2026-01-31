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
public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0)
        {
            return head;
        }
        int length = 0;
        ListNode temp = head;
        while (temp != null)
        {
            length++;
            temp = temp.next;
        }

        k = k % length;

        int cnt = 0;
        while (cnt < k)
        {
            ListNode curr = head;

            while (curr.next.next != null)
            {
                curr = curr.next;
            }

            ListNode last = curr.next;
            curr.next = null;

            last.next = head;

            head = last;
            cnt++;
        }
        return head;
    }
}