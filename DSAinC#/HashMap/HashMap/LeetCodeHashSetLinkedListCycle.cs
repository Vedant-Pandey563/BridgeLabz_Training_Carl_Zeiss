/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public bool HasCycle(ListNode head)
    {
        HashSet<ListNode> set = new HashSet<ListNode>();
        ListNode temp = head;

        while (temp != null)
        {
            if (set.Contains(temp))
            {
                return true;
            }

            set.Add(temp);

            temp = temp.next;
        }

        return false;
    }
}