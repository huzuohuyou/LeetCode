using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_113_DFS : ISolution
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
        List<IList<int>> result = new List<IList<int>>();
        List<int> path = new List<int>();
        public void dfs(TreeNode root, int sum)
        {
            if (root == null)
            {
                return;
            }
            sum -= root.val;
            path.Add(root.val);
            if (root.left == null && root.right == null)
            {
                result.Add(path.ToArray());
            }
            else if (root.left!=null&&root.right!=null)
            {
                dfs(root.left, sum);
                path.RemoveAt(path.Count - 1);
                dfs(root.right, sum);
                path.RemoveAt(path.Count - 1);
            }
            else
            {
                dfs(root.left, sum);
                dfs(root.right, sum);
                path.RemoveAt(path.Count - 1);


            }
        }

        public IList<IList<int>> PathSum(TreeNode root, int sum)
        {
            dfs(root, sum);
            var t = result.Where(r => r.Sum() == sum).ToList();
            return t;

        }
    }
}
