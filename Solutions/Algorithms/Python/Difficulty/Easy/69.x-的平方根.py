#
# @lc app=leetcode.cn id=69 lang=python3
#
# [69] x 的平方根
#

# @lc code=start
class Solution:
    def mySqrt(self, x: int) -> int:
        if x < 2: return x
        left, right = 0, x
        while left <= right:
            mid = left + (right - left) // 2
            sqrt = x // mid
            if sqrt > mid:
                left = mid + 1
            elif sqrt < mid:
                right = mid - 1
            else:
                return sqrt
        return right
# @lc code=end

