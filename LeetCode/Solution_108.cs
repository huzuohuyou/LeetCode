using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
   
    public class Solution_108: ISolution
    {
        public void Test()
        {
            int[] nums = { -10, -3, 0, 5, 9 };
            var tree = SortedArrayToBST(nums);
        }

        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums.Length==0)
            {
                return null;
            }
            var mid = nums.Length / 2;
            var numsL = nums.Skip(0).Take(mid).ToArray();
            var numsR = nums.Skip(mid+1).Take(mid).ToArray();
            var root = new TreeNode(nums[mid]);
            root.left = SortedArrayToBST(numsL);
            root.right = SortedArrayToBST(numsR);
            return root;
        }
    }
}
