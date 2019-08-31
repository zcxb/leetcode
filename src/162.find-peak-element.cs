/*
 * @lc app=leetcode id=162 lang=csharp
 *
 * [162] Find Peak Element
 */
public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        int len = nums.Length;
        if (len == 1) return 0;
        int lo = 0, hi = len;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            int midValue = nums[mid];

            if (mid == 0)
            {
                if (midValue > nums[mid + 1]) return mid;
                else lo = mid + 1;
            }
            else if (mid == len - 1)
            {
                if (midValue > nums[mid - 1]) return mid;
                else hi = mid;
            }
            else {
                if (midValue > nums[mid - 1] && midValue > nums[mid + 1]) return mid;
                else if (midValue > nums[mid - 1]) lo = mid + 1;
                else hi = mid;
            }
        }
        throw new System.Exception();
    }
}

