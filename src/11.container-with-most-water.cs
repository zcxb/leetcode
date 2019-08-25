/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */
public class Solution
{
    public int MaxArea(int[] height)
    {
        int area = 0;
        int start = 0;
        int end = height.Length - 1;
        while (start < end)
        {
            area = Math.Max(area, Math.Min(height[start], height[end]) * (end - start));
            if (height[start] <= height[end])
            {
                start++;
            }
            else
            {
                end--;
            }
        }
        return area;
    }
}

