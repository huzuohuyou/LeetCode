using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO59_1 : ISolution
    {
        
        public void Test()
        {
           
            var a = MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 },3);
        }


        public double[] TwoSum(int n)
        {
            if (k > nums.Length || nums.Length == 0)
            {
                return nums;
            }
            var array = new int[nums.Length - k + 1];
            for (int l = 0, r = l + k - 1; l < nums.Length - k + 1; l++)
            {
                array[l] = nums.Skip(l).Take(k).ToArray().Max();
            }
            return array;
        }
    }
}

