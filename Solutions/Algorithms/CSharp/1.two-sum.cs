/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int length = nums.Length;
        for (int i = 0; i < length - 1; i++)
        {
            var lhs = nums[i];
            for (int j = i + 1; j < length; j++)
            {
                var rhs = nums[j];
                if (lhs + rhs == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        throw new System.Exception("no solution");
    }
}

