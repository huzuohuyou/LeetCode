using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO35 : ISolution
    {

        public void Test()
        {
            var n5 = new TreeNode(5);
            var n4 = new TreeNode(4);
            n5.left = n4;
            var n8 = new TreeNode(8);
            n5.right = n8;

            var n11 = new TreeNode(11);
            n4.left = n11;
            var n13 = new TreeNode(13);
            n8.left = n13;
            var n4_2 = new TreeNode(4);
            n8.right = n4_2;


            var n7 = new TreeNode(7);
            n11.left = n7;
            var n2 = new TreeNode(2);
            n11.right = n2;
            var n5_2 = new TreeNode(5);
            n4_2.left = n5_2;
            var n1 = new TreeNode(1);
            n4_2.right = n1;

            var r = PathSum(n5,22);

        }


        List<IList<int>> res = new List<IList<int>>();
        List<int> path = new List<int>();
        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            recur(root, sum);
            return res;
        }
        void recur(TreeNode root, int tar)
        {
            if (root == null) return;
            path.Add(root.val);
            tar -= root.val;
            if (tar == 0 && root.left == null && root.right == null)
                res.Add(new List<int>(path));
            recur(root.left, tar);
            recur(root.right, tar);
            path.RemoveAt(path.Count-1);
        }

        


    }
}

