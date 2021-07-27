#
# @lc app=leetcode.cn id=763 lang=python3
#
# [763] 划分字母区间
#

# @lc code=start
class Solution:
    def partitionLabels(self, s: str) -> List[int]:

        map = dict()
        for i, c in enumerate(s):
            if c not in map:
                map[c] = [i, i]
            map[c] = [map[c][0], i]
        lengths = []
        last = None
        for k, v in map.items():
            print(f'{k}: {v}')
            if not last:
                last = v
            print(last)
            if last[1] < map[k][0]:
                lengths.append(last[1] - last[0] + 1)
                last = map[k]
            else:
                last[1] = max(last[1], map[k][1])
        lengths.append(last[1] - last[0] + 1)
        return lengths
# @lc code=end


# 未必需要记录第一次出现的index