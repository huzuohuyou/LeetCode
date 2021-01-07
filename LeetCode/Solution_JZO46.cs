using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO46 : ISolution
    {
        public void Test()
        {
            var s = TranslateNum(1314);
        }
        public int TranslateNum(int num)
        {
            String src = num.ToString();
            int p = 0, q = 0, r = 1;
            for (int i = 0; i < src.Length; ++i)
            {
                p = q;
                q = r;
                r = 0;
                r += q;
                if (i == 0)
                {
                    continue;
                }
                String pre = src.Substring(i - 1, 2);
                if (pre.CompareTo("25") <= 0 && pre.CompareTo("10") >= 0)
                {
                    r += p;
                }
            }
            return r;

  
        }
    }
}

