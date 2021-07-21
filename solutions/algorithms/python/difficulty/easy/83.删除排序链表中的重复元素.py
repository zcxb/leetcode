#
# @lc app=leetcode.cn id=83 lang=python3
#
# [83] 删除排序链表中的重复元素
#

# @lc code=start
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def deleteDuplicates(self, head: ListNode) -> ListNode:
        begin = head
        if head == None:
            return begin
        else:
            while head.next != None:
                if head.val == head.next.val:
                    head.next = head.next.next
                else:
                    head = head.next
        return begin
# @lc code=end
