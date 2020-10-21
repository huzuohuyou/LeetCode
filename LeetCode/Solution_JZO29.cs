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
            while (matrix.Length > 1)
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    result.Add(matrix[0][i]);
                    if (i == matrix[0].Length - 1)
                    {
                        matrix = matrix.Skip(1).Take(matrix.Length - 1).ToArray();
                        matrix = GetArray(matrix);
                        if (matrix.Length == 1)
                        {
                            break;
                        }
                        SpiralOrder(matrix);
                    }
                }
            }
            foreach (var item in matrix[0])
            {
                result.Add(item);
            }

            return result.ToArray();
        }


        public int[][] GetArray(int[][] array)
        {
            var temp = new int[array[0].Length][];
            for (int j = array[0].Length - 1; j >= 0; j--)

            {
                var item = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    item[i] = array[i][j];
                }
                temp[array[0].Length - j - 1] = item;
            }
            return temp;

        }


    }
}

