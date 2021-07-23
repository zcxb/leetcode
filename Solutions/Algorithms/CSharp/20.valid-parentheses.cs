/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */
public class Solution
{
    public bool IsValid(string s)
    {
        List<char> stack = new List<char>();
        char lastChar;
        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Count > 0)
            {
                lastChar = stack[stack.Count - 1];
                if ((s[i].Equals(')') && lastChar.Equals('('))
                        || (s[i].Equals(']') && lastChar.Equals('['))
                        || (s[i].Equals('}') && lastChar.Equals('{')))
                {
                    stack.RemoveAt(stack.Count - 1);
                    continue;
                }
            }
            stack.Add(s[i]);
        }
        return stack.Count == 0;
    }
}

