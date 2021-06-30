using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode
{
    /// <summary>
    /// 剑指 Offer 67. 把字符串转换成整数
    /// https://leetcode-cn.com/problems/ba-zi-fu-chuan-zhuan-huan-cheng-zheng-shu-lcof/
    /// </summary>
    public class Solution_JZO67 : ISolution
    {

        public void Test()
        {
            //2147483648
            var b = StrToInt("20000000000000000000");
        }


        public int StrToInt(string str)
        {
            int res = 0, bndry = int.MaxValue / 10;
            int i = 0, sign = 1, length = str.Length;
            if (length == 0) return 0;
            while (str[i] == ' ')
                if (++i == length) return 0;
            if (str[i] == '-') sign = -1;
            if (str[i] == '-' || str[i] == '+') i++;
            for (int j = i; j < length; j++)
            {
                if (str[j] < '0' || str[j] > '9') break;
                if (res > bndry || res == bndry && str[j] > '7')
                    return sign == 1 ? int.MaxValue : int.MinValue;
                res = res * 10 + (str[j] - '0');
            }
            return sign * res;

       
        }
    }
}

