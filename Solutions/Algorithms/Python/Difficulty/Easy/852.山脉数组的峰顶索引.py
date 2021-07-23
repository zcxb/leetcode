#
# @lc app=leetcode.cn id=852 lang=python3
#
# [852] 山脉数组的峰顶索引
#

# @lc code=start
class Solution:
    def peakIndexInMountainArray(self, arr: List[int]) -> int:
        low = 0
        high = len(arr) - 1
        while low <= high:
            mid = (low + high) // 2
            if arr[mid] > arr[mid - 1] and arr[mid] > arr[mid + 1]:
                return mid
            elif arr[mid] > arr[mid - 1] and arr[mid] < arr[mid + 1]:
                low = mid + 1
            elif arr[mid] < arr[mid - 1] and arr[mid] > arr[mid + 1]:
                high = mid - 1
# @lc code=end

