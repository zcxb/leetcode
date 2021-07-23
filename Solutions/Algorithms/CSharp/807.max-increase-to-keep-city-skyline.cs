/*
 * @lc app=leetcode id=807 lang=csharp
 *
 * [807] Max Increase to Keep City Skyline
 */
public class Solution
{
    public int MaxIncreaseKeepingSkyline(int[][] grid)
    {
        int len = grid.Length;
        int[] topMax = new int[len];
        int[] leftMax = new int[len];

        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                topMax[j] = Math.Max(topMax[j], grid[i][j]);
                leftMax[i] = Math.Max(leftMax[i], grid[i][j]);
            }
        }

        int count = 0;

        for (int i = 0; i < len; i++)
        {
            for (int j = 0; j < len; j++)
            {
                count += Math.Min(topMax[j], leftMax[i]) - grid[i][j];
            }
        }

        return count;
    }
}

