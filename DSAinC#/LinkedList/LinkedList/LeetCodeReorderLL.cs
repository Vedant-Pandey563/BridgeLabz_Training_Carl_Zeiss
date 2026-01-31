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

    public void ReorderList(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head.next;

        while (fast != null && fast.next != null)//fast is 2x of slow , when fast is at  end slow will be at mid
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode second = slow.next; //second half of list starts from mid
        slow.next = null;

        ListNode prev = null;

        //reversing the second half
        while (second != null)
        {
            ListNode temp = second.next;
            second.next = prev;
            prev = second;
            second = temp;
        }

        ListNode first = head;
        second = prev;

        while (second != null)
        {
            ListNode x = first.next;
            ListNode y = second.next;

            first.next = second;
            second.next = x;

            first = x;
            second = y;
        }

    }
}