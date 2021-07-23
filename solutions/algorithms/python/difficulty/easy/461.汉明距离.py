#
# @lc app=leetcode.cn id=461 lang=python3
#
# [461] 汉明距离
#

# @lc code=start
class Solution:
    def hammingDistance(self, x: int, y: int) -> int:
        # 位异或后转二进制字符串，计算1的个数
        return bin(x ^ y).count('1')
# @lc code=end

