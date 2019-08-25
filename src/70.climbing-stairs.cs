/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */
public class Solution
{
    public int ClimbStairs(int n)
    {
        // DP: f(n) = f(n - 1) + f(n - 2)
        // Fibonacci !!!
        // Use Fibonacci Formula:
        double sqrt5 = Math.Sqrt(5);
        var fibn = (Math.Pow((1 + sqrt5) / 2, n + 1) - Math.Pow((1 - sqrt5) / 2, n + 1)) / sqrt5;
        return (int)fibn;
    }
}

