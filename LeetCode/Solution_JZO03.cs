using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO03 : ISolution
    {
        public void Test()
        {

            var x = FindRepeatNumber(new int[] { 1, 0, 3, 5, 9, 12 });
        }

        public int FindRepeatNumber(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var r in nums)
            {
                if (!set.Contains(r))
                {
                    set.Add(r);
                }
                else
                {
                    return r;
                }
            }
            return -1;
            
        }
    }
}
