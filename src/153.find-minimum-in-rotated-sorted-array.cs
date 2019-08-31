/*
 * @lc app=leetcode id=153 lang=csharp
 *
 * [153] Find Minimum in Rotated Sorted Array
 */
public class Solution
{
    public int FindMin(int[] nums)
    {
        int len = nums.Length;
        if (len == 1) return nums[0];
        if (nums[0] < nums[len - 1]) return nums[0];

        int lo = 0, hi = len;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            int tmp = nums[mid];
            if (mid == len - 1 && tmp < nums[mid - 1]) return tmp;
            else if (tmp > nums[mid + 1]) return nums[mid + 1];
            if (tmp > nums[0])
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid;
            }
        }
        return int.MinValue;
    }
}

