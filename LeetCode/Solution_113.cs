using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_113 : ISolution
    {
        public void Test()
        {
            var root = new TreeNode(5);
            var l1 = new TreeNode(4);
            root.left = l1;
            var r1 = new TreeNode(8);
            root.right = r1;

            var l2 = new TreeNode(11);
            l1.left = l2;
            var rl1 = new TreeNode(13);
            r1.left = rl1;
            var r1r = new TreeNode(4);
            r1.right = r1r;

            var node41 = new TreeNode(7);
            l2.left = node41;

            var node42 = new TreeNode(2);
            l2.right = node42;
            var node43 = new TreeNode(5);
            r1r.left = node43;
            var node44 = new TreeNode(1);
            r1r.right = node44;
            var r = PathSum(root, 22);
        }
        public bool IsLeef(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null)
            {
                return true;
            }
            return false;
        }

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            if (root == null)
            {
                return new List<IList<int>>();
            }
            else if (root.left == null && root.right == null)
            {
                if (sum == root.val)
                {
                    return new List<IList<int>>() { new List<int> { root.val } };
                }
                return new List<IList<int>>();
            }
            else
            {
                var result = new List<IList<int>>();
                var valuequeue = new Queue();
                var queue = new Queue();
                queue.Enqueue(root);
                valuequeue.Enqueue(new List<int> { root.val });
                while (queue.Count > 0)
                {
                    var size = queue.Count;
                    for (int i = 0; i < size; i++)
                    {

                        var node = (TreeNode)queue.Dequeue();
                        var item = (List<int>)valuequeue.Dequeue();
                        
                        if (IsLeef(node) && item.Sum() == sum)
                        {
                            result.Add(item);
                        }
                        if (node.left != null)
                        {
                            queue.Enqueue(node.left);
                            var temp = new List<int>(item);
                            temp.Add(node.left.val);
                            valuequeue.Enqueue(temp);
                        }

                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                            var temp = new List<int>(item);
                            temp.Add(node.right.val);
                            valuequeue.Enqueue(temp);
                        }

                    }
                }
                return result;
            }


        }
    }
}
