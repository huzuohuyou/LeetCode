using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO11 : ISolution
    {
        public void Test()
        {
            var f = MinArray(new int[3] { 1, 3, 4 });
        }
        public int MinArray(int[] numbers)
        {
            int low = 0, high = numbers.Length - 1;
            while (low < high)
            {
                var pivot = low + (high - low) / 2;
                if (numbers[high] < numbers[pivot])
                {
                    high = pivot;
                }
                else if (numbers[pivot] > numbers[high])
                {
                    low = pivot + 1;
                }
                else
                {
                    high = high - 1;
                }
            }
            return numbers[low];
        }

        //public int MinArray(int[] numbers)
        //{
        //    var temp = numbers[0] - 1;
        //    var index = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (temp > numbers[i])
        //        {
        //            temp = numbers[i];
        //            break;
        //        }
        //        temp = numbers[i];
        //        index = i;
        //    }
        //    return index == numbers.Length - 1 ? numbers[0] : temp;
        //}
    }
}
