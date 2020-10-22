using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO39 : ISolution
    {
        public void Test()
        {
           

        }


        public int MajorityElement(int[] nums)
        {
            int vote = 0, x = 0;
            foreach (var item in nums)
            {
                if (vote==0)
                {
                    x = item;
                }
                vote += item == x ? 1 : -1;
            }
            return x;
        }
    }
}

