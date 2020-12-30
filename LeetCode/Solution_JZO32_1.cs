using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO32_1 : ISolution
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
            var r = LevelOrder(root);

        }


        public int[] LevelOrder(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
            {
                return result.ToArray();
            }
            else
            {
                var queue = new Queue();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    int size = queue.Count;
                    for (int i = 0; i < size; i++)
                    {
                        var node = (TreeNode)queue.Dequeue();
                        result.Add(node.val);
                        if (node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }
                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }
                    }
                }
                return result.ToArray();
            }
        }
    }
}

