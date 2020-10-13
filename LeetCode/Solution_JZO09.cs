using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO09 : ISolution
    {
        public void Test()
        {
            CQueue obj = new CQueue();
            int param_0 = obj.DeleteHead();
            obj.AppendTail(5);
            obj.AppendTail(2);
            int param_1 = obj.DeleteHead();
            int param_2 = obj.DeleteHead();
        }

        public class CQueue
        {
            Stack<int> left = new Stack<int>();
            Stack<int> right = new Stack<int>();
            public CQueue()
            {

            }

            public void AppendTail(int value)
            {
                if (left.Count==0)
                {
                    left.Push(value);
                }
                else
                {
                    while (left.Count>0)
                    {
                        var item = left.Pop();
                        right.Push(item);
                    }
                    left.Push(value);
                    while (right.Count>0)
                    {
                        var item = right.Pop();
                        left.Push(item);
                    }
                }
            }

            public int DeleteHead()
            {
                if (left.Count>0)
                {
                    var item =left.Pop();
                    return item;
                }return -1;
            }
        }

    }
}
