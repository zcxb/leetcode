/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        var len = nums.Length;
        if (len == 0) return 0;
        if (len == 1) return nums[0];

        var prev = nums[0];
        var sum = prev;
        for (int i = 1; i < len; i++)
        {
            prev = prev > 0 ? prev + nums[i] : nums[i];
            sum = Math.Max(sum, prev);
        }
        return sum;
    }
}

