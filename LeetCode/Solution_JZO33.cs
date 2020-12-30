using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO33 : ISolution
    {

        public void Test()
        {
            //var root = new TreeNode(1);
            //var l1 = new TreeNode(2);
            //root.left = l1;
            //var r1 = new TreeNode(3);
            //root.right = r1;

            //var r1l = new TreeNode(4);
            //l1.left = r1l;
            //var r1r = new TreeNode(5);
            //r1.right = r1r;
            //var r = VerifyPostorder(root);

        }


        public Boolean VerifyPostorder(int[] postorder)
        {
            return recur(postorder, 0, postorder.Length - 1);
        }
        Boolean recur(int[] postorder, int i, int j)
        {
            if (i >= j) return true;
            int p = i;
            while (postorder[p] < postorder[j]) p++;
            int m = p;
            while (postorder[p] > postorder[j]) p++;
            return p == j && recur(postorder, i, m - 1) && recur(postorder, m, j - 1);
        }


    }
}

