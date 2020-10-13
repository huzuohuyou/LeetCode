using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO10 : ISolution
    {
        public void Test()
        {
            var f = Fib(41);
        }

        Dictionary<int,int> dict = new Dictionary<int, int>();
        public int Fib(int n)
        {
            if (n>=0&&n<=100)
            {
                int f0 = 0, f1 = 1;
                int f2 = f0+f1;
                if (n == 0)
                {
                    return 0;
                }
                if (n == 1)
                {
                    return 1;
                }
                else
                {
                    for (int i = 2; i < n; i++)
                    {
                        f2 = (f0 + f1)%1000000007;
                        f0 = f1;
                        f1 = f2;
                    }
                    return f2;
                }
            }
            return -1;

        }
    }
}
