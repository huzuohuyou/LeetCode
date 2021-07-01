using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 剑指 Offer 63. 股票的最大利润
    /// https://leetcode-cn.com/problems/gu-piao-de-zui-da-li-run-lcof/
    /// </summary>
    public class Solution_JZO63 : ISolution
    {

        public void Test()
        {

            var a = MaxProfit(new int[] { 4, 7, 5, 2, 9 });
        }


        public int MaxProfit(int[] prices)
        {

            if (prices.Length<=1)
            {
                return 0;
            }
            int cost = int.MaxValue, profit = 0;
            foreach (var price in prices)
            {
                cost = Math.Min(cost, price);
                profit = Math.Max(profit, price - cost);
            }
            return profit;

     
        }
    }
}

