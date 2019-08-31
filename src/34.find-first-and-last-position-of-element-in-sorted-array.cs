/*
 * @lc app=leetcode id=34 lang=csharp
 *
 * [34] Find First and Last Position of Element in Sorted Array
 */
public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] res = new int[2] { -1, -1 };
        if (nums.Length == 0) return res;
        int lo = 0, hi = nums.Length - 1;
        
        while (lo < hi)
        {
            int mid = (hi - lo) / 2 + lo;
            if (nums[mid] < target)
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid;
            }
        }

        if (nums[lo] == target)
        {
            res[0] = lo;
        }
        else
        {
            return res;
        }

        hi = nums.Length - 1;
        while (lo < hi)
        {
            int mid = (hi - lo) / 2 + lo + 1;
            if (nums[mid] > target)
            {
                hi = mid - 1;
            }
            else
            {
                lo = mid;
            }
        }
        res[1] = hi;

        return res;
    }
}


