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
            ValidateStackSequences(new int[] { 1,2,3,4,5}, new int[] { 4, 5, 3, 2, 1 });

        }
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            Stack<int> stack = new Stack<int>();
            int i = 0;
            foreach (int num in pushed)
            {
                stack.Push(num); // num 入栈
                while (!(stack.Count()==0) && stack.Peek() == popped[i])
                { // 循环判断与出栈
                    stack.Pop();
                    i++;
                }
            }
            return stack.Count() == 0;


        }
    }
}

