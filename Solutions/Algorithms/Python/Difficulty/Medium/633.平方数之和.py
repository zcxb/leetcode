#
# @lc app=leetcode.cn id=633 lang=python3
#
# [633] 平方数之和
#

# @lc code=start
import math

class Solution:
    def judgeSquareSum(self, c: int) -> bool:
        if c <= 2: return True
        a, b = 0, math.floor(math.sqrt(c))
        while a <= b:
            s = a * a + b * b
            if s < c:
                a += 1
            elif s > c:
                b -= 1
            else:
                return True
        return False
# @lc code=end

