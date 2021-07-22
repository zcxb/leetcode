#
# @lc app=leetcode.cn id=202 lang=python3
#
# [202] 快乐数
#

# @lc code=start
class Solution:
    def isHappy(self, n: int) -> bool:
        sums = set()
        while True:
            sum = self.calcSum(n)
            if sum not in sums:
                sums.add(sum)
                n = sum
            else:
                return False
            if sum == 1:
                return True 

    def calcSum(self, num: int) -> int:
        sum = 0
        while num > 0:
            sum += (num % 10) * (num % 10)
            num //= 10
        return sum
# @lc code=end
