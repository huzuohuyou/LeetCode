using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO32_3 : ISolution
    {

        public void Test()
        {
            var root = new TreeNode(1);
            var l1 = new TreeNode(2);
            root.left = l1;
            var r1 = new TreeNode(3);
            root.right = r1;

            var r1l = new TreeNode(4);
            l1.left = r1l;
            var r1r = new TreeNode(5);
            r1.right = r1r;
            var r = LevelOrder(root);

        }


        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var ok = false;
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
                    if (ok)
                    {
                        item.Reverse();
                        
                    }
                    result.Add(item);
                    ok = !ok;
                }
                return result;
            }
        }
    }
}

