#
# @lc app=leetcode.cn id=704 lang=python3
#
# [704] 二分查找
#

# @lc code=start
class Solution:
    def search(self, nums: List[int], target: int) -> int:
        low, high = 0, len(nums) - 1
        while low <= high: 
            mid = low + (high - low) // 2 # 防止越界
            if nums[mid] < target:
                low = mid + 1  
            elif nums[mid] > target:
                high = mid - 1 
            else:
                return mid
        return -1
# @lc code=end

