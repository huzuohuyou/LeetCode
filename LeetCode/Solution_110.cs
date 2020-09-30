using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_110 : ISolution
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
            //var yes = IsBalanced(root);
       
             TestNo();
        }

        public void TestNo()
        {
            var root = new TreeNode(1);
            var l1 = new TreeNode(2);
            root.left = l1;
            var r1 = new TreeNode(2);
            root.right = r1;

            var l3 = new TreeNode(3);
            l1.left = l3;
            var r3 = new TreeNode(3);
            l1.right = r3;

            var l4 = new TreeNode(4);
            l3.left = l4;
            var r4 = new TreeNode(4);
            l3.right = r4;
            
            var no = IsBalanced(root);
        }

        public int TreeHeight(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                int heightL = 1, heightR = 1;
                if (root.right != null || root.left != null)
                {
                    if (root.left != null) { heightL = TreeHeight(root.left) + 1; }

                    if (root.right != null) { heightR = TreeHeight(root.right) + 1; }
                }
                return Math.Max(heightR, heightL);
            }

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
