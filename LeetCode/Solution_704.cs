using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_704 : ISolution
    {
        public void Test()
        {

            var x = Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2);
        }

        public int Search(int[] nums, int target)
        {
            if (nums==null||nums.Length==0)
            {
                return -1;
            }
            var index = 0;
            var l = 0; ;
            var r = nums.Length - 1;
            while (l<=r)
            {
                index = l + (r - l) / 2;
                var mid = nums[index];
                if (mid == target)
                {
                    return index;
                }
                if ( target < mid)//下区间
                {
                    r = index-1;
                }
                else //上区间
                {
                    l = index+1;
                }

            }
            return -1;
        }
    }
}
