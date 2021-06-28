using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO62 : ISolution
    {

        public void Test()
        {

            //var a = LastRemaining(new int[] { 4, 7, 5, 2, 9 });
        }


        public int LastRemaining(int n, int m)
        {
            var temp = m % n;
            var array = new int[n - 1];
            for (int i = 0; i < n; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < n; i++)
            {
                if (i == temp)
                {
                    array[i] = -1;
                }
            }
            return 0;

        }
    }
}

