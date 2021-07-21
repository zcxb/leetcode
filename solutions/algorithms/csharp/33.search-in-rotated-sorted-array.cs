/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */
public class Solution
{
    public int Search(int[] nums, int target)
    {
        int lo = 0, hi = nums.Length;
        while (lo < hi)
        {
            int fst = nums[0];
            if (fst == target) return 0;
            var mid = (hi - lo) / 2 + lo;
            var midValue = nums[mid];
            int tmp = midValue; 
            if (target <= fst && midValue > fst)
            {
                tmp = int.MinValue;
            }
            else if (target >= fst && midValue < fst)
            {
                tmp = int.MaxValue;
            }

            if (tmp < target)
            {
                lo = mid + 1;
            }
            else if (tmp > target)
            {
                hi = mid;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }
}

