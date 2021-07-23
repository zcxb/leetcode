#
# @lc app=leetcode.cn id=203 lang=python3
#
# [203] 移除链表元素
#

# @lc code=start
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def removeElements(self, head: ListNode, val: int) -> ListNode:
        saveHead = head = ListNode(0, head)
        curr = head.next
        while curr:
            if curr.val == val:
                head.next = curr.next
            else:
                head = head.next
            curr = curr.next
        return saveHead.next
# @lc code=end

