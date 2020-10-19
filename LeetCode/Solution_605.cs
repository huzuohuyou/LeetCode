using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
   
    public class Solution_605: ISolution
    {
        public void Test()
        {
            var array = new int[] {1,0,0,0,0,1,1,0,0 };
            var ok = CanPlaceFlowers(array, 3);
        }

        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int temp = -1,count=0;
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (i + 1< flowerbed.Length
                    &&flowerbed[i]==0
                    &&temp==0
                    && flowerbed[i+1]==0)
                {
                    count++;
                }
                temp = flowerbed[i];
            }
            return count >= n;
        }
    }
}
