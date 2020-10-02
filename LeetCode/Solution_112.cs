using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_112 : ISolution
    {
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
            var r = HasPathSum(root,22);
        }
        public bool IsLeef(TreeNode root)
        {
            if (root==null)
            {
                return false;
            }
            if (root.left == null && root.right == null)
            {
                return true;
            }
            return false;
        }

        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }
            else if (root.left == null && root.right == null)
            {

                return sum==root.val;
            }
            else
            {
                var pahtsum = new List<int>();
                var valuequeue = new Queue();
                var queue = new Queue();
                queue.Enqueue(root);
                valuequeue.Enqueue(root.val);
                while (queue.Count > 0)
                {
                    var size = queue.Count;
                    for (int i = 0; i < size; i++)
                    {
                        var node = (TreeNode)queue.Dequeue();
                        var temp= (int)valuequeue.Dequeue();
                        
                        if (IsLeef(node))
                        {
                             pahtsum.Add(temp);
                        }
                        if (node.left != null) {
                            queue.Enqueue(node.left);
                            valuequeue.Enqueue(node.left.val+temp);
                        }
                            
                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                            valuequeue.Enqueue(node.right.val + temp);
                        }
                            
                    }
                }
                return pahtsum.Contains(sum);
            }


        }
    }
}
