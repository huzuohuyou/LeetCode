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
        int count = 0;
        public int MovingCount(int m, int n, int k)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dfs(m, n, i, j, k))
                    {
                        count++;
                    }
                }
            }

            return count;
        }
        int GetSum(int x)
        {
            var sum = 0;
            foreach (var item in x.ToString())
            {
                sum += int.Parse(item.ToString());
            }
            return sum;
        }
        public bool dfs(int m, int n, int x, int y, int k)
        {
            if (x < 0 || x > m || y < 0 || y > n || (GetSum(x) + GetSum(y)) > k)
            {
                return false;
            }

            if ((GetSum(x) + GetSum(y)) <= k)
            {
                return true;

            };
            if (dfs(m,n,x-1,y,k)
                || dfs(m, n, x+1, y, k) 
                || dfs(m, n, x, y-1, k) 
                || dfs(m, n, x, y+1, k))
            {

            }
            return false;
        }
    }
}

