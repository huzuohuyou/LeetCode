using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO57_2 : ISolution
    {
        
        public void Test()
        {
           
            var a = FindContinuousSequence(15);
        }


        public int[][] FindContinuousSequence(int target)
        {
            var result = new List<int[]>();
            for (int i = 1,j=2;  i< j; )
            {
                var sum = (i + j) * (j - i + 1) / 2;
                if (sum==target)
                {
                    var list = new List<int>();
                    for (int m = i; m <= j - i + 1; m++)
                    {
                        list.Add(m);
                    }
                    result.Add(list.ToArray());
                    i++;
                }
                else if (sum<target)
                {
                    j++;
                }
                else if (sum>target)
                {
                    i++;
                }
            }
            return result.ToArray();
        }
    }
}

