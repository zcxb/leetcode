/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var len = nums.Length;
        if (len == 0) return 0;
        var head = 0;
        int last = nums[0];
        for (int i = 1; i < len; i++)
        {
            var val = nums[i];
            if (last != val) {
                head++;
                nums[head] = val;
                last = val;
            }
        }
        return head + 1;
    }
}

