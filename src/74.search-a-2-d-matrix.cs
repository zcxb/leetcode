/*
 * @lc app=leetcode id=74 lang=csharp
 *
 * [74] Search a 2D Matrix
 */
public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int M = matrix.Length;
        if (M == 0) return false;
        int N = matrix[0].Length;
        if (N == 0) return false;
        int lo = 0, hi = M * N;
        int mid = 0;
        while (lo < hi)
        {
            mid = lo + (hi - lo) / 2;
            System.Console.Write($"index: {lo}|{mid}|{hi},");
            int midValue = getMatrixValue(mid, matrix);
            System.Console.Write($"value: {midValue};");

            if (midValue == target) return true;

            if (midValue < target)
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid;
            }
        }
        return target == getMatrixValue(mid, matrix);
    }

    private int getMatrixValue(int index, int[][] matrix)
    {
        int N = matrix[0].Length;
        return matrix[index / N][index % N];
    }
}

