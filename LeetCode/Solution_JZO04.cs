using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO05 : ISolution
    {
        public void Test()
        {

            //var x = FindRepeatNumber(new int[] { 1, 0, 3, 5, 9, 12 });
        }
        public string ReplaceSpace(string s)
        {
            var sb = new StringBuilder();
            foreach (var item in s.ToArray())
            {
                if (item.Equals(' '))
                {
                    sb.Append("%20");
                }
                else
                {
                    sb.Append(item);
                }
            }
            return sb.ToString();
            
           

        }
      
    }
}
