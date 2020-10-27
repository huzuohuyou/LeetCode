using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO58_2 : ISolution
    {
        
        public void Test()
        {
           
            var a = ReverseLeftWords("abcdefg",2);
        }


        public string ReverseLeftWords(string s, int n)
        {
            var sb = new StringBuilder(s);
            for (int i = 0; i < n; i++)
            {
                sb.Append(s[i]);
            }
           var r= sb.ToString(n,s.Length - n + 1);
            return r;
        }
    }
}

