using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
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
            var r = new Solution().LevelOrderBottom(root);
            Console.WriteLine("Hello World!");
        }
    }
}
