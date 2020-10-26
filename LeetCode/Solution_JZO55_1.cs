using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO55_1 : ISolution
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
            var a = MaxDepth(root);
        }

        
        

        public int MaxDepth(TreeNode root)
        {
            int Deph = 0;
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;

            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count>0)
            {
                var size = queue.Count;
                
                Deph++;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (node.left!=null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right!=null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                
            }
            return Deph;
        }
    }
}

