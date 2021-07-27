#
# @lc app=leetcode.cn id=122 lang=python3
#
# [122] 买卖股票的最佳时机 II
#

# @lc code=start
class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        sum = 0
        for i in range(1, len(prices)):
            if prices[i] > prices[i - 1]:
                sum += prices[i] - prices[i - 1]
            print(sum)
        return sum
# @lc code=end

