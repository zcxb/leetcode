#
# @lc app=leetcode.cn id=11 lang=python3
#
# [11] 盛最多水的容器
#

# @lc code=start
class Solution:
    def maxArea(self, height: List[int]) -> int:
        left, right = 0, len(height) - 1
        area = 0
        while left < right:
            shorter = min(height[left], height[right])
            area = max(area, shorter * (right - left))
            # 从短边开始缩短距离
            if height[left] < height[right]:
                left += 1
            else:
                right -= 1
        return area
# @lc code=end

