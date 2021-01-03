using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO44 : ISolution
    {
        public void Test()
        {
            var s = FindNthDigit(11);
        }
        public int FindNthDigit(int n)
        {
            long bitCount = 1;//n对应数字的位数
            long start = 1;   //bitCount位的最小数
            long count = 9;  //bitCount位中所有所有数位总和
            long curNum = 0;  //当前数

            while (n > count)
            {
                n -= (int)count;
                bitCount++;
                start *= 10;
                count = 9 * start * bitCount;
            }

            curNum = start + (n - 1) / bitCount;//确定当前数
            string str = curNum.ToString();
            return str[(n - 1) % (int)bitCount] - '0';//-'0'将char转对应int值

        }
    }
}

