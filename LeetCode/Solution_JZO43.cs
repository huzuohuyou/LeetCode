using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 剑指 Offer 43. 1～n 整数中 1 出现的次数
    /// https://leetcode-cn.com/problems/1nzheng-shu-zhong-1chu-xian-de-ci-shu-lcof/
    /// </summary>
    public class Solution_JZO43 : ISolution
    {
        public void Test()
        {

            var s = CountDigitOne(8);
        }
        public int CountDigitOne(int n)
        {
            int digit = 1, res = 0;
            int high = n / 10, cur = n % 10, low = 0;
            while (high != 0 || cur != 0)
            {
                if (cur == 0) res += high * digit;
                else if (cur == 1) res += high * digit + low + 1;
                else res += (high + 1) * digit;
                low += cur * digit;
                cur = high % 10;
                high /= 10;
                digit *= 10;
            }
            return res;

        }
    }
}

