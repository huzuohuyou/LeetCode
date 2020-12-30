using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO32_2 : ISolution
    {

        public void Test()
        {
           

        }


        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var item = new List<int>();
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
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

