/*
 * @lc app=leetcode id=19 lang=csharp
 *
 * [19] Remove Nth Node From End of List
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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var HEAD = new ListNode(0);
        HEAD.next = head;
        var curr = HEAD.next;
        for (int i = 1; i < n; i++)
        {
            curr = curr.next;
        }
        var ptr = HEAD;
        while (curr.next != null)
        {
            curr = curr.next;
            ptr = ptr.next;
        }
        ptr.next = ptr.next.next;
        return HEAD.next;
    }
}

