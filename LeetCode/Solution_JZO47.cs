using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class Solution_JZO47 : ISolution
    {
        public void Test()
        {
            
        }

        public int MaxValue(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length;
            for (int j = 1; j < n; j++) // 初始化第一行
                grid[0][j] += grid[0][j - 1];
            for (int i = 1; i < m; i++) // 初始化第一列
                grid[i][0] += grid[i - 1][0];
            for (int i = 1; i < m; i++)
                for (int j = 1; j < n; j++)
                    grid[i][j] += Math.Max(grid[i][j - 1], grid[i - 1][j]);
            return grid[m - 1][n - 1];
        }

    }
}

