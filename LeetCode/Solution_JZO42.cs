using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO42 : ISolution
    {
        public void Test()
        {

            var array = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var s = MaxSubArray(array);
        }
        public int MaxSubArray(int[] nums)
        {
            int res = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += Math.Max(nums[i - 1], 0);
                res = Math.Max(res, nums[i]);
            }
            return res;

        }
    }
}

