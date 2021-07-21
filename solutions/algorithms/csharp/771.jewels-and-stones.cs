/*
 * @lc app=leetcode id=771 lang=csharp
 *
 * [771] Jewels and Stones
 */
public class Solution
{
    public int NumJewelsInStones(string J, string S)
    {
        HashSet<char> Jewels = new HashSet<char>();
        foreach (var j in J)
        {
            Jewels.Add(j);
        }
        int count = 0;
        foreach (var s in S)
        {
            if (Jewels.Contains(s))
            {
                count++;
            }
        }
        return count;
    }
}

