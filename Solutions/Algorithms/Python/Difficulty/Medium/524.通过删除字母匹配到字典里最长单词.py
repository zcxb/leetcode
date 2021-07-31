#
# @lc app=leetcode.cn id=524 lang=python3
#
# [524] 通过删除字母匹配到字典里最长单词
#

# @lc code=start
class Solution:
    def findLongestWord(self, s: str, dictionary: List[str]) -> str:
        dictionary.sort(key=lambda x: (-len(x), x)) # 先排序
        for item in dictionary:
            i = 0
            for c in s:
                if c == item[i]:
                    i += 1
                if i == len(item):
                    return item # 找到直接返回答案
        return ''
# @lc code=end

