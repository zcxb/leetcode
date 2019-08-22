/*
 * @lc app=leetcode id=1108 lang=csharp
 *
 * [1108] Defanging an IP Address
 */
public class Solution
{
    public string DefangIPaddr(string address)
    {
        string res = string.Empty;
        for (int i = 0; i < address.Length; i++)
        {
            var c = address[i].ToString();
            if (c.Equals("."))
            {
                res += "[.]";
            }
            else
            {
                res += c;
            }
        }
        return res;
    }
}

