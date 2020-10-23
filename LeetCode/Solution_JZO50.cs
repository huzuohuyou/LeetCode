using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO50 : ISolution
    {
        public void Test()
        {

            FirstUniqChar("cc");
        }
        public char FirstUniqChar(string s)
        {
            if (s.Equals(""))
            {
                return ' ';
            }
            var dict = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item] = dict[item]+1;
                }
                else
                {
                    dict.Add(item, 1);
                }

            }
            return dict.Where(r => r.Value == 1).Count() == 0 ? ' ' : dict.Where(r => r.Value == 1).FirstOrDefault().Key;
        }
    }
}

