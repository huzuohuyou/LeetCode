using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO38 : ISolution
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode() { }

            public TreeNode(int _val, TreeNode _left = null, TreeNode _right = null)
            {
                val = _val;
                left = _left;
                right = _right;
            }


        }

        public void Test()
        {
            var s = Permutation("abc");
        }


        List<String> res = new List<String>();
        char[] c;
        public String[] Permutation(String s)
        {
            c = s.ToCharArray();
            dfs(0);
            return res.ToArray();
        }
        void dfs(int x)
        {
            if (x == c.Count() - 1)
            {
                res.Add(new string(c)); // 添加排列方案
                return;
            }
            HashSet<char> set = new HashSet<char>();
            for (int i = x; i < c.Length; i++)
            {
                if (set.Contains(c[i])) continue; // 重复，因此剪枝
                set.Add(c[i]);
                swap(i, x); // 交换，将 c[i] 固定在第 x 位 
                dfs(x + 1); // 开启固定第 x + 1 位字符
                swap(i, x); // 恢复交换
            }
        }
        void swap(int a, int b)
        {
            char tmp = c[a];
            c[a] = c[b];
            c[b] = tmp;
        }

     

    }
}

