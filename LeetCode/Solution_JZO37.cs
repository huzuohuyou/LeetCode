using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO37 : ISolution
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
            var n2 = new TreeNode(2, null, null);
            var n4 = new TreeNode(4, null, null);
            var n5 = new TreeNode(5, null, null);
            var n3 = new TreeNode(3, n4, n5);
            var n1 = new TreeNode(1, n2, n3);
            var s = serialize(n1);
            var n = deserialize(s);
        }


        public string serialize(TreeNode root)
        {
            if (root == null) return "[]";
            StringBuilder res = new StringBuilder("[");
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node != null)
                {
                    res.Append(node.val + ",");
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
                else res.Append("null,");
            }
            res.Remove(res.Length - 1, 1);
            res.Append("]");
            return res.ToString();
        }

        public TreeNode deserialize(String data)
        {
            if (data.Equals("[]")) return null;
            String[] vals = data.Substring(1, data.Length - 2).Split(",");
            TreeNode root = new TreeNode(int.Parse(vals[0]));
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int i = 1;
            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (!vals[i].Equals("null"))
                {
                    node.left = new TreeNode(int.Parse(vals[i]));
                    queue.Enqueue(node.left);
                }
                i++;
                if (!vals[i].Equals("null"))
                {
                    node.right = new TreeNode(int.Parse(vals[i]));
                    queue.Enqueue(node.right);
                }
                i++;
            }
            return root;
        }

    }
}

