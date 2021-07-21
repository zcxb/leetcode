/*
 * @lc app=leetcode id=83 lang=csharp
 *
 * [83] Remove Duplicates from Sorted List
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
    public ListNode DeleteDuplicates(ListNode head)
    {
        var res = head;
        while (head != null && head.next != null)
        {
            if (head.val == head.next.val)
            {
                head.next = head.next.next;
            }
            else
            {
                head = head.next;
            }
        }
        return res;
    }
}

