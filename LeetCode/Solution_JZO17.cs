using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO17 : ISolution
    {
        public void Test()
        {
            var f = PrintNumbers(0001);
        }
        public int[] PrintNumbers(int n)
        {
            
            var max = 1;
            for (int i = 0; i < n; i++)
            {
                max *= 10;
            }
            var array = new int[max];
            for (int i = 1; i <= max-1; i++)
            {
                array[i - 1] = i;
            }
            return array;
        }
    }
}

