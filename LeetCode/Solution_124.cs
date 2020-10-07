using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_124 : ISolution
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
            var r = MaxPathSum(root);
            var x = result;   
        }
        List<int> result = new List<int>();

        private void dfs(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            if (root.left != null)
            {
                dfs(root.left);
            }
            result.Add(root.val);
            if (root.right != null)
            {
                dfs(root.right);
            }
            //if (root.left == null && root.right == null)
            //{
            //    result.Add(root.val);
            //}

        }


        public List<int> MaxPathSum(TreeNode root)
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
                //路径和
                if (root.right==null&&root.left==null)
                {//叶子节点
                    list.Add(root.val);
                }
                else
                {
                    //dfs(root.left);
                    dfs(root.right);
                }
                //list.Add(root.val);
                root = root.right;
                
            }
        }
    }
}
