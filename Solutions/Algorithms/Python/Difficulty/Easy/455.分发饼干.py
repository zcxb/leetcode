#
# @lc app=leetcode.cn id=455 lang=python3
#
# [455] 分发饼干
#

# @lc code=start
class Solution:
    def findContentChildren(self, g: List[int], s: List[int]) -> int:
        # g: 胃口
        # s: 饼干
        g.sort()
        s.sort()
        sum = index = 0
        while sum < len(g) and index < len(s):
            if g[sum] <= s[index]:
                sum += 1
            index += 1
        return sum
# @lc code=end

