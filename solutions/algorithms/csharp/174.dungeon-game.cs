/*
 * @lc app=leetcode id=174 lang=csharp
 *
 * [174] Dungeon Game
 */
public class Solution
{
    public int CalculateMinimumHP(int[][] dungeon)
    {
        int M = dungeon.Length;
        int N = dungeon[0].Length;

        int[,] dp = new int[M, N];

        for (int i = M - 1; i >= 0; i--)
        {
            for (int j = N - 1; j >= 0; j--)
            {
                var tmp = 0;
                if (i == M - 1 && j == N - 1)
                {
                    tmp = 1 - dungeon[i][j];
                }
                else if (j == N - 1)
                {
                    tmp = dp[i + 1, j] - dungeon[i][j];
                }
                else if (i == M - 1)
                {
                    tmp = dp[i, j + 1] - dungeon[i][j];
                }
                else
                {
                    tmp = Math.Min(dp[i, j + 1], dp[i + 1, j]) - dungeon[i][j];
                }
                Console.Write($"[{i}][{j}]: tmp - {tmp}, ");
                var val = Math.Max(1, tmp);
                dp[i, j] = val;
                Console.WriteLine($"health - {val}");
            }
        }
        return dp[0, 0];
    }
}

