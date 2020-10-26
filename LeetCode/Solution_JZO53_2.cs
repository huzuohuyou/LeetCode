using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO53_2 : ISolution
    {

        public void Test()
        {
            var a = MissingNumber(new int[] { 0, 1, 2, 4, 5, 6, 7, 8, 9 });
        }

        public int MissingNumber(int[] nums)
        {
            int i = 0, j = nums.Length - 1;
            while (i <= j)
            {
                int m = (i + j) / 2;
                if (nums[m] == m)
                    i = m + 1;
                else
                    j = m - 1;
            }
            return i;
        }
    }
}

