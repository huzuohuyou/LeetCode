using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO40 : ISolution
    {
        public void Test()
        {
           

        }
        void quick_sort(int[] s, int l, int r)
        {
            if (l < r)
            {
                //Swap(s[l], s[(l + r) / 2]); //将中间的这个数和第一个数交换 参见注1
                int i = l, j = r, x = s[l];
                while (i < j)
                {
                    while (i < j && s[j] >= x) // 从右向左找第一个小于x的数
                        j--;
                    if (i < j)
                        s[i++] = s[j];

                    while (i < j && s[i] < x) // 从左向右找第一个大于等于x的数
                        i++;
                    if (i < j)
                        s[j--] = s[i];
                }
                s[i] = x;
                quick_sort(s, l, i - 1); // 递归调用 
                quick_sort(s, i + 1, r);
            }
        }

        public int[] GetLeastNumbers(int[] arr, int k)
        {
            if (k == 0 || arr.Length == 0)
            {
                return new int[0];
            }
            quick_sort(arr, 0, arr.Length-1);
            // 最后一个参数表示我们要找的是下标为k-1的数
            return arr.Take(k).ToArray();

        }
    }
}

