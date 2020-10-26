using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO55_2 : ISolution
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
            var root = new TreeNode(5);
            var l1 = new TreeNode(3);
            root.left = l1;
            var r1 = new TreeNode(6);
            root.right = r1;

            var r1l = new TreeNode(2);
            l1.left = r1l;
            var r1r = new TreeNode(4);
            l1.right = r1r;

            var r2r = new TreeNode(1);
            r1l.left = r2r;
            var a = IsBalanced(root);
        }


        public int Depth(TreeNode root) {
            if (root==null)
            {
                return 0;

            }
            return Math.Max(Depth(root.left), Depth(root.right)) + 1;
        }

        public bool IsBalanced(TreeNode root)
        {
            if (root==null)
            {
                return true;
            }
            return Math.Abs(Depth(root.left) - Depth(root.right)) <= 1
                && IsBalanced(root.left)
                && IsBalanced(root.right);
            
        }
    }
}

