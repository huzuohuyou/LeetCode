using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO28 : ISolution
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
            var root = new TreeNode(3);
            var l1 = new TreeNode(9);
            root.left = l1;
            var r1 = new TreeNode(20);
            root.right = r1;

            var r1l = new TreeNode(15);
            r1.left = r1l;
            var r1r = new TreeNode(7);
            r1.right = r1r;
            var r = IsSymmetric(root);
        }

        public bool Mirror(TreeNode l, TreeNode r)
        {
            if (l == null && r == null)
            {
                return true;
            }
            if (l == null || r == null || l.val != r.val)
            {
                return false;
            }
            return Mirror(l.right, r.left) && Mirror(l.left, r.right);
        }

        public bool IsSymmetric(TreeNode root)
        {
            return root == null ? true : Mirror(root.left, root.right);
        }
    }
}

