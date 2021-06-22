using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO68_1 : ISolution
    {

        public void Test()
        {

            //var a = Add(1,2);
        }


        public TreeNode lowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode ancestor = root;
            while (true)
            {
                if (p.val < ancestor.val && q.val < ancestor.val)
                {
                    ancestor = ancestor.left;
                }
                else if (p.val > ancestor.val && q.val > ancestor.val)
                {
                    ancestor = ancestor.right;
                }
                else
                {
                    break;
                }
            }
            return ancestor;
        }
    }
}

