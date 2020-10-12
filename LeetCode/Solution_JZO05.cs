using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO04 : ISolution
    {
        public void Test()
        {

            //var x = FindRepeatNumber(new int[] { 1, 0, 3, 5, 9, 12 });
        }
        public int? FindExistNumber(int[] nums,int target)
        {
            foreach (var r in nums)
            {
                if (r.Equals(target))
                {
                    return r;
                }
                
            }
            return null;

        }
        public bool FindNumberIn2DArray(int[][] matrix, int target)
        {
            var ok = false;
            var set = new HashSet<int>();
            foreach (var array in matrix)
            {
               
                if (array.Length>0&&array[0] <= target)
                {
                    ok= FindExistNumber(array,target) != null||ok  ;
                }
            }
            return ok;

        }
    }
}
