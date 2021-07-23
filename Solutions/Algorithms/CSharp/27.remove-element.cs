/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        var len = nums.Length;
        if (len == 0) return 0;
        var head = 0;
        for (int i = 0; i < len; i++)
        {
            var num = nums[i];
            if (val != num) {
                nums[head] = num;
                head++;
            }
        }
        return head;
    }
}

