using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO21 : ISolution
    {
        
        public void Test()
        {
            
        }
        public int[] Exchange(int[] nums)
        {
            int fast = 0, slow = 0;
            while (fast<nums.Length)
            {
                if (nums[fast]%2==0)
                {
                    var temp = nums[slow];
                    nums[fast] = nums[slow];
                    nums[slow] = temp;
                    slow++;
                }
                fast++;

            }
            return nums;
        }
    }
}

