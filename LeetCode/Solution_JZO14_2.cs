using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO14_2 : ISolution
    {
        public void Test()
        {
            var f = CuttingRope(22);
        }
        int count = 0;
        public int CuttingRope(int n)
        {
            //if (n <= 3) return n - 1;
            //int a = n / 3, b = n % 3;
            //if (b == 0) return (int)Math.Pow(3, a);
            //if (b == 1) return (int)Math.Pow(3, a - 1) * 4;
            //return (int)Math.Pow(3, a) * 2;

            if (n <= 3) return n - 1;
            int b = n % 3, p = 1000000007;
            long rem = 1, x = 3;
            for (int a = n / 3 - 1; a > 0; a /= 2)
            {
                if (a % 2 == 1) rem = (rem * x) % p;
                x = (x * x) % p;
            }
            if (b == 0) return (int)(rem * 3 % p);
            if (b == 1) return (int)(rem * 4 % p);
            return (int)(rem * 6 % p);

        

        }
    }
}

