/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
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
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        var p = l1;
        var q = l2;
        ListNode head = new ListNode(0);
        var curr = head;
        while (p != null || q != null)
        {
            if (p == null)
            {
                curr.next = q;
                break;
            }
            if (q == null)
            {
                curr.next = p;
                break;
            }
            if (p.val <= q.val)
            {
                curr.next = new ListNode(p.val);
                p = p.next;
            }
            else
            {
                curr.next = new ListNode(q.val);
                q = q.next;
            }
            curr = curr.next;
        }
        return head.next;
    }
}

