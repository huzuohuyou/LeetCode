using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO65 : ISolution
    {

        public void Test()
        {

            var a = Add(1,2);
        }


        public int Add(int a, int b)
        {
            while (b != 0)
            { // 当进位为 0 时跳出
                int c = (a & b) << 1;  // c = 进位
                a ^= b; // a = 非进位和
                b = c; // b = 进位
            }
            return a;
        }
    }
}

