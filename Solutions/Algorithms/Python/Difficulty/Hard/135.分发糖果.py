#
# @lc app=leetcode.cn id=135 lang=python3
#
# [135] 分发糖果
#

# @lc code=start
class Solution:
    def candy(self, ratings: List[int]) -> int:
        arr = [1]* len(ratings)
        for i in range(1, len(ratings)):
            if ratings[i] > ratings[i - 1]:
                arr[i] = arr[i - 1] + 1
        j = len(ratings) - 1
        while j > 0:
            if ratings[j] < ratings[j - 1]:
                arr[j - 1] = max(arr[j] + 1, arr[j - 1])
            j -= 1
        return sum(arr)
# @lc code=end

