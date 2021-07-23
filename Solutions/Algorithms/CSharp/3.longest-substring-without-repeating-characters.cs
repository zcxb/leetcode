/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int count = 0;
        int len = s.Length;
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int start = 0;
        for (int pos = 0; pos < len; pos++)
        {
            var c = s[pos];
            if (dict.ContainsKey(c))
            {
                // jump to 'pos + 1'
                start = Math.Max(dict[c] + 1, start);
            }
            // current length of substring: pos - start + 1
            count = Math.Max(count, pos - start + 1);
            dict[c] = pos;
        }
        return count;
    }
}

