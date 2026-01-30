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
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode temp = new ListNode(0, head);
        ListNode curr = temp;

        while (curr.next != null)
        {
            if (curr.next.val == val)
            {
                curr.next = curr.next.next;
            }
            else
            {
                curr = curr.next;
            }

        }

        return temp.next;

    }
}