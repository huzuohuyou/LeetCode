using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO29 : ISolution
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public void Test()
        {
            //var array = new int[][] { 
            //new int[]{1,2,3,4 },
            //new int[]{10,11,12,5 },
            //new int[]{9,8,7,6 },
            //};

            var array = new int[][] {
            new int[]{1,2,3, },
            new int[]{4,5,6 },
            new int[]{7,8,9 },
            };
            var r = SpiralOrder(array);
        }
        List<int> result = new List<int>();
        public int[] SpiralOrder(int[][] matrix)
        {
            if (matrix.Length == 0) return new int[0];
            int l = 0, r = matrix[0].Length - 1, t = 0, b = matrix.Length - 1, x = 0;
            int[] res = new int[(r + 1) * (b + 1)];
            while (true)
            {
                for (int i = l; i <= r; i++) res[x++] = matrix[t][i]; // left to right.
                if (++t > b) break;
                for (int i = t; i <= b; i++) res[x++] = matrix[i][r]; // top to bottom.
                if (l > --r) break;
                for (int i = r; i >= l; i--) res[x++] = matrix[b][i]; // right to left.
                if (t > --b) break;
                for (int i = b; i >= t; i--) res[x++] = matrix[i][l]; // bottom to top.
                if (++l > r) break;
            }
            return res;

         
        }


        //public int[][] GetArray(int[][] array)
        //{
        //    var temp = new int[array[0].Length][];
        //    for (int j = array[0].Length - 1; j >= 0; j--)

        //    {
        //        var item = new int[array.Length];
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            item[i] = array[i][j];
        //        }
        //        temp[array[0].Length - j - 1] = item;
        //    }
        //    return temp;

        //}


    }
}

