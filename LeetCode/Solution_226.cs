using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_226 : ISolution
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
            var r = InvertTree(root);
        }
       

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            else if (root.left == null && root.right == null)
            {

                return root;
            }
            else
            {
                var l = InvertTree(root.left);
                var temp = l;
                var r = InvertTree(root.right);
                root.right = temp;
                root.left = r;
            }
            return root;

        }
    }
}
