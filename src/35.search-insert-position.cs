/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */
public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var len = nums.Length;
        if (len == 0 || nums[0] >= target) return 0;
        for (int i = 0; i < len; i++)
        {
            if (i == len - 1)
            {
                if (target > nums[i]) return len;
            }
            if (nums[i] < target && nums[i + 1] >= target) return i + 1;
        }
        throw new Exception();
    }
}

