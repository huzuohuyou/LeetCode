using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 构建乘积数组
    /// https://leetcode-cn.com/problems/gou-jian-cheng-ji-shu-zu-lcof/
    /// </summary>
    public class Solution_JZO66 : ISolution
    {

        public void Test()
        {
            var b = ConstructArr(new int[] {1, 2, 3, 4, 5 });
        }


        public int[] ConstructArr(int[] a)
        {
            if (a.Length == 0) return new int[0];
            int[] b = new int[a.Length];
            b[0] = 1;
            int tmp = 1;
            for (int i = 1; i < a.Length; i++)
            {
                b[i] = b[i - 1] * a[i - 1];
            }
            for (int i = a.Length - 2; i >= 0; i--)
            {
                tmp *= a[i + 1];
                b[i] *= tmp;
            }
            return b;

        }
    }
}

