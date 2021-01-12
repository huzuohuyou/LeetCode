using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO56_2 : ISolution
    {
   
        public void Test()
        {
            var s= SingleNumber(new int[]{ 1,2,2,1,5});
        }

        public int SingleNumber(int[] nums)
        {
            int ones = 0, twos = 0;
            foreach (int num in nums)
            {
                ones = ones ^ num & ~twos;
                twos = twos ^ num & ~ones;
            }
            return ones;
        }

     

   
    }
}

