using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO57_1 : ISolution
    {
        
        public void Test()
        {
           
            var a = TwoSum(new int[] { 2, 7, 11, 15 },9);
        }


        public int[] TwoSum(int[] nums, int target)
        {
            int start = 0, end = nums.Length - 1;
            var array = new int[2];
            while (start<end)
            {
                if (nums[start]+nums[end]>target)
                {
                    end--;
                }
                else if (nums[start] + nums[end]< target)
                {
                    start++;
                }else
                {
                    array[0] = nums[start];
                    array[1] = nums[end];
                    break;
                }
            }
            return array;
            
        }
    }
}

