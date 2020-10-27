using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO58_1 : ISolution
    {
        
        public void Test()
        {
           
            var a = ReverseWords("a good   example");
        }


        public string ReverseWords(string s)
        {
            var stack = new Stack<string>();
            var array = s.Split(' ');
            foreach (var item in array)
            {
                if (item!="")
                {
                    stack.Push(item.Trim());
                }
                
            }
            StringBuilder sb = new StringBuilder();
            while (stack.Count>0)
            {
                sb.Append(" ");
                sb.Append(stack.Pop());
            }
            return sb.ToString().Trim();
        }
    }
}

