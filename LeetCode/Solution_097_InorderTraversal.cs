using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{

    public class Solution_097_InorderTraversal : ISolution
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
            var r = InorderTraversal(root);

        }
        List<int> result = new List<int>();

        private void dfs(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            if (root.left!=null)
            {
                dfs(root.left);
            }
            result.Add(root.val);
            if (root.right != null)
            {
                dfs(root.right);
            }
            
            
        }
        public IList<int> InorderTraversal(TreeNode root)
        {
            var stact = new Stack<TreeNode>();
            var list = new List<int>();
            while (true){
                while (root!=null)
                {
                    stact.Push(root);
                    root = root.left;
                }
                if (stact.Count==0)
                {
                    return list;
                }
                root = stact.Pop();
                list.Add(root.val);
                root = root.right;

            }
        }
    }
}
