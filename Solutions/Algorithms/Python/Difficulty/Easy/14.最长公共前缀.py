#
# @lc app=leetcode.cn id=14 lang=python3
#
# [14] 最长公共前缀
#

# @lc code=start
class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        # ascii 码排序法
        smin, smax = min(strs), max(strs)
        for i, s in enumerate(smin):
            if s != smax[i]:
                return smax[:i]
        return smin
# @lc code=end
