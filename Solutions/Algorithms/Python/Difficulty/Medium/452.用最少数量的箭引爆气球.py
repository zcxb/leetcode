#
# @lc app=leetcode.cn id=452 lang=python3
#
# [452] 用最少数量的箭引爆气球
#

# @lc code=start
class Solution:
    def findMinArrowShots(self, points: List[List[int]]) -> int:
        if len(points) < 2: return len(points)
        points.sort(key=lambda p: (p[0], p[1]))
        n = 0
        last = None
        for i in range(0, len(points)):
            if not last:
                last = points[i]
                n += 1
            else:
                if last[1] < points[i][0]:
                    last = points[i]
                    n += 1
                last[1] = min(last[1], points[i][1])
        return n
# @lc code=end

