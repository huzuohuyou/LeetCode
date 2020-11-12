using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO31 : ISolution
    {

        public void Test()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            var c = minStack.Min();
            minStack.Pop();
            var a = minStack.Top();
            var b = minStack.Min();

        }
        public class MinStack
        {
            public Stack<int> A = new Stack<int>();
            public Stack<int> B = new Stack<int>();
            /** initialize your data structure here. */
            public MinStack()
            {

            }

            public void Push(int x)
            {
                A.Push(x);
                if (B.Count==0||x<=B.Peek())
                {
                    B.Push(x);
                }
            }

            public void Pop()
            {
                if (A.Pop().Equals(B.Peek()))
                {
                    B.Pop();
                }
            }

            public int Top()
            {
                
                return A.Peek();
            }

            public int Min()
            {
                if (B.Count > 0)
                {
                    return  B.Peek();
                }return A.Peek();
                
            }
        }
    }
}

