using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO61 : ISolution
    {

        public void Test()
        {

            var a = IsStraight(new int[] { 4, 7, 5, 2, 9 });
        }


        public bool IsStraight(int[] nums)
        {
            var list = nums.ToList();

            list.Sort();
            nums = list.ToArray();
            int max = 0, min = 14, cout = 0, temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    cout++;
                }
                else
                {
                    if (nums[i] > max)
                    {
                        max = nums[i];
                    }
                    if (min > nums[i])
                    {
                        min = nums[i];
                    }
                    if (temp == nums[i])
                    {

                        return false;
                    }
                    temp = nums[i];
                }
            }
            if ((max - min) <= cout || (max - min) <= 4)
            {
                return true;
            }
            return false;
        }
    }
}

