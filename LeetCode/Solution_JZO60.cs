using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 剑指 Offer 60. n个骰子的点数
    /// https://leetcode-cn.com/problems/nge-tou-zi-de-dian-shu-lcof/
    /// </summary>
    public class Solution_JZO60 : ISolution
    {
        
        public void Test()
        {
            var r = DicesProbability(2);
        }


        public double[] DicesProbability(int n)
        {
            double[] dp = new double[6] { 1.0 / 6.0 , 1.0 / 6.0 ,1.0 / 6.0, 1.0 / 6.0 , 1.0 / 6.0 , 1.0 / 6.0 };
            for (int i = 2; i <= n; i++)
            {
                double[] tmp = new double[5 * i + 1];
                for (int j = 0; j < dp.Length; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        tmp[j + k] += dp[j] / 6.0;
                    }
                }
                dp = tmp;
            }
            return dp;


        }
    }
}

