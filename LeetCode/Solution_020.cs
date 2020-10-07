using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_020 : ISolution
    {
        public void Test()
        {

            var x = IsValid("((");
        }

        public bool IsLeftChar(char s)
        {
            if ("([{".Contains(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPair(char l, char r)
        {
            if (l.Equals('(') && r.Equals(')')
                || l.Equals('[') && r.Equals(']')
                || l.Equals('{') && r.Equals('}'))
            {
                return true;
            }
            return false;

        }
        public bool IsValid(string s)
        {
            if (s.Length%2!=0)
            {
                return false;
            }
            var array = s.ToArray();
            var stack = new Stack<char>();
            var ok = true;
            array.ToList().ForEach(l =>
            {
                if (IsLeftChar(l))
                {
                    stack.Push(l);
                }
                else
                {
                    if (stack.Count>0)
                    {
                        var s = stack.Pop();
                        ok = ok && IsPair(s, l);
                    }
                    else
                    {
                        ok = ok && false;
                    }
                    
                }
            });
            return stack.Count==0&& ok;
        }
    }
}
