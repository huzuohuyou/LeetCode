using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_111 : ISolution
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
            var r = new Solution_111().MinDepth(root);
        }


        public int MinDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else if (root.left == null && root.right == null)
            {

                return 1;
            }
            else
            {
                var depth = 1;
                var queue = new Queue();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    depth++;
                    var size = queue.Count;
                    for (int i = 0; i < size; i++)
                    {
                        var node = (TreeNode)queue.Dequeue();
                        if (IsLeef(node))
                        {
                            break;
                        }
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }
                }
                return depth;
            }

            private bool CheckNode(TreeNode root)
        {
            if (root == null)
                return true;
            else
            {
                var isB = Math.Abs(TreeHeight(root.left) - TreeHeight(root.right));
                if (isB > 1)
                {
                    return false;
                }
                return true;
                
            }

        }

        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;
            else
            {
                return CheckNode(root)
                    && IsBalanced(root.right) 
                    && IsBalanced(root.left) ;
            }
        }
    }
}
