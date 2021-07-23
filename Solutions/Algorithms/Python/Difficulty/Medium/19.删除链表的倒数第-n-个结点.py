#
# @lc app=leetcode.cn id=19 lang=python3
#
# [19] 删除链表的倒数第 N 个结点
#

# @lc code=start
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def removeNthFromEnd(self, head: ListNode, n: int) -> ListNode:
        fakeHead = ListNode(0, head)
        last = curr = fakeHead
        while last.next and n > 0:
            last = last.next
            n -= 1
        while last.next:
            last = last.next
            curr = curr.next
        curr.next = curr.next.next
        return fakeHead.next
# @lc code=end

