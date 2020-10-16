using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO15 : ISolution
    {
        public void Test()
        {
            var f = HammingWeight(0001);
        }
        public int HammingWeight(uint n)
        {
            uint res = 0;
            while (n!=0)
            {
                res += n & 1;
                n >>= 1;
            }
            return int.Parse(res.ToString());
        }
    }
}

