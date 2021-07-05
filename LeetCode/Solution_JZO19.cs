using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 剑指 Offer 19. 正则表达式匹配
    /// https://leetcode-cn.com/problems/zheng-ze-biao-da-shi-pi-pei-lcof/
    /// </summary>
    public class Solution_JZO19 : ISolution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public void Test()
        {



            var f = IsMatch("aab", "c*a*b");
        }
        public bool IsMatch(string s, string p)
        {

            int m = s.Length;
            int n = p.Length;

            var f = new bool[m + 1, n + 1];
            f[0, 0] = true;
            for (int i = 0; i <= m; ++i)
            {
                for (int j = 1; j <= n; ++j)
                {
                    if (p[j - 1] == '*')
                    {
                        f[i, j] = f[i, j - 2];
                        if (matches(s, p, i, j - 1))
                        {
                            f[i, j] = f[i, j] || f[i - 1, j];
                        }
                    }
                    else
                    {
                        if (matches(s, p, i, j))
                        {
                            f[i, j] = f[i - 1, j - 1];
                        }
                    }
                }
            }
            return f[m, n];
        }

        public bool matches(String s, String p, int i, int j)
        {
            if (i == 0)
            {
                return false;
            }
            if (p[j - 1] == '.')
            {
                return true;
            }
            return s[i - 1] == p[j - 1];
        }


    }
}

