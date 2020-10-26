using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO54 : ISolution
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
            var a = KthLargest(root,3);
        }

        List<TreeNode> list = new List<TreeNode>();
        public void Dfs(TreeNode root) {
            if (root==null)
            {
                return;
            }
            if (root.left==null&&root.right==null)
            {
                list.Add(root);

            }
            else
            {
                if (root.right != null)
                {
                    Dfs(root.right);
                }
                list.Add(root);
                if (root.left!=null)
                {
                    Dfs(root.left);
                }
                
            }

        }

        public int KthLargest(TreeNode root, int k)
        {
            Dfs(root);
            return list[k - 1].val;
        }
    }
}

