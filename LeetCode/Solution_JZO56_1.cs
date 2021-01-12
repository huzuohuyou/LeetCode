using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO56_1 : ISolution
    {
   
        public void Test()
        {
            var s= SingleNumbers(new int[]{ 1,2,2,1,5});
        }

        public int[] SingleNumbers(int[] nums)
        {
            int xorSum = 0;
            int[] ret = new int[2] { 0, 0 };
            foreach (int x in nums) xorSum ^= x;

            int lowbit = xorSum & (-xorSum);
            foreach (int x in nums)
            {
                ret[(x & lowbit) > 0 ? 0 : 1] ^= x;
            }

            return ret;
        }

   
    }
}

