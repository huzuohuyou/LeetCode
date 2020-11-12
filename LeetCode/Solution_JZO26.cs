using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO26 : ISolution
    {
       
        public void Test()
        {
            var root = new TreeNode(3);
            
        }
        public bool IsSubStructure(TreeNode A, TreeNode B)
        {
            return (A != null && B != null) 
                && (recur(A, B) 
                || IsSubStructure(A.left, B) 
                || IsSubStructure(A.right, B));
        }
        bool recur(TreeNode A, TreeNode B)
        {
            if (B == null) return true;
            if (A == null || A.val != B.val) return false;
            return recur(A.left, B.left) && recur(A.right, B.right);
        }


    }
}

