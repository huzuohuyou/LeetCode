using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO13 : ISolution
    {
        public void Test()
        {
            var f = MovingCount(2, 3, 1);
        }
        private int m;

        private int n;

        private int k;

        private int total;

        private bool[,] check;


        public int MovingCount(int m, int n, int k)
        {
            if (m == 0 || n == 0)
            {
                return 0;
            }

            this.m = m;
            this.n = n;
            this.k = k;
            check = new bool[m, n];


            dfs(0, 0);
            return total;
        }

        public void dfs(int x, int y)
        {
            if (x >= m || y >= n || Sum(x) + Sum(y) > k || check[x, y])
            {
                return;
            }

            check[x, y] = true;

            total++;

            dfs(x + 1, y);
            dfs(x, y + 1);
        }

        public int Sum(int input)
        {
            int result = 0;
            while (input > 0)
            {
                var yushu = input % 10;
                result += yushu;
                input = input / 10;
            }

            return result;
        }
    }
}

