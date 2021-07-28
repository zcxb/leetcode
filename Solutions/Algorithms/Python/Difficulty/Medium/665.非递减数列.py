#
# @lc app=leetcode.cn id=665 lang=python3
#
# [665] 非递减数列
#

# @lc code=start
class Solution:
    def checkPossibility(self, nums: List[int]) -> bool:
        if len(nums) < 3: return True
        n = 0
        i = 1
        while i < len(nums) and n < 2:
            if nums[i] < nums[i - 1]:
                n += 1
                if i - 2 >= 0 and nums[i - 2] > nums[i]:
                    nums[i] = nums[i - 1]
                else:
                    nums[i - 1] = nums[i]
            i += 1
        return n < 2
# @lc code=end

# 修改当前值时，需要和前前一个值比较