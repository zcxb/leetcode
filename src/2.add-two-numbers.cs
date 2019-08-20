/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode head = new ListNode(0);
        ListNode a = l1;
        ListNode b = l2;
        ListNode curr = head;
        int tmp = 0;
        while (a != null || b != null)
        {
            int x = a == null ? 0 : a.val;
            int y = b == null ? 0 : b.val;
            int r = x + y + tmp;
            tmp = r / 10;
            curr.next = new ListNode(r % 10);
            curr = curr.next;
            if (a != null)
            {
                a = a.next;
            }
            if (b != null)
            {
                b = b.next;
            }
        }

        if (tmp > 0)
        {
            curr.next = new ListNode(tmp);
        }

        return head.next;
    }
}

