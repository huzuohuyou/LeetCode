using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO44 : ISolution
    {
        public void Test()
        {
            //var s = FindNthDigit(11);
        }
        public String MinNumber(int[] nums)
        {
            String[] strs = new String[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                strs[i] = nums[i].ToString();
            fastSort(strs, 0, strs.Length - 1);
            StringBuilder res = new StringBuilder();
            foreach (var s in strs)
                res.Append(s);
            return res.ToString();
        }
        void fastSort(String[] strs, int l, int r)
        {
            if (l >= r) return;
            int i = l, j = r;
            String tmp = strs[i];
            while (i < j)
            {
                while ((strs[j] + strs[l]).CompareTo(strs[l] + strs[j]) >= 0 && i < j) j--;
                while ((strs[i] + strs[l]).CompareTo(strs[l] + strs[i]) <= 0 && i < j) i++;
                tmp = strs[i];
                strs[i] = strs[j];
                strs[j] = tmp;
            }
            strs[i] = strs[l];
            strs[l] = tmp;
            fastSort(strs, l, i - 1);
            fastSort(strs, i + 1, r);
        }

    }
}

