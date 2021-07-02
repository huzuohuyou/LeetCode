using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 剑指 Offer 64. 求1+2+…+n
    /// https://leetcode-cn.com/problems/qiu-12n-lcof/
    /// </summary>
    public class Solution_JZO64 : ISolution
    {

        public void Test()
        {

            var a = SumNums(7);
        }


        public int SumNums(int n)
        {
            bool x = n > 1 && (n += SumNums(n - 1)) > 0;
            return n;
        }
    }
}

