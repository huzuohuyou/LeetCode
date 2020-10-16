using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO10_2 : ISolution
    {
        public void Test()
        {
            var f = NumWays(7);
        }
        int index = 0;
        public int NumWays(int n)
        {
            int a = 1, b = 1,sum=0;

            for (int i = 0; i <n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return a;
        }
    }
}
