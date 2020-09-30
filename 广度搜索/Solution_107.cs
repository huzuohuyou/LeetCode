using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 广度搜索
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    public class Solution
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }
            else
            {
                var queue = new Queue();
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    var item = new List<int>();
                    int size = queue.Count;
                    for (int i = 0; i < size; i++)
                    {
                        var node = (TreeNode)queue.Dequeue();
                        item.Add(node.val);
                        if (node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }
                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }
                    }
                    result.Add(item);
                }
                return result;
            }
        }
    }
}
