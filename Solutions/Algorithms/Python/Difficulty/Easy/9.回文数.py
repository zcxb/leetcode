#
# @lc app=leetcode.cn id=9 lang=python3
#
# [9] 回文数
#

# @lc code=start
class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0:
            return False
        xCopy = x
        xNew = x % 10
        while x >= 10:
            x //= 10
            xNew = 10 * xNew + x % 10 
        return xNew == xCopy
# @lc code=end

