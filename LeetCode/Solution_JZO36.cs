using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO36 : ISolution
    {
        public class Node
        {
            public int val;
            public Node left;
            public Node right;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
                left = null;
                right = null;
            }

            public Node(int _val, Node _left, Node _right)
            {
                val = _val;
                left = _left;
                right = _right;
            }
        }

        public void Test()
        {
            var n1 = new Node(1, null, null);
            var n3 = new Node(3, null, null);
            var n2 = new Node(2, null, null);
            n2.left = n1;
            n2.right = n3;
            var n5 = new Node(5, null, null);
            var n4 = new Node(4, n2, n5);
            var r = TreeToDoublyList(n4);
        }


        Node pre, head;
        public Node TreeToDoublyList(Node root)
        {
            if (root == null) return null;
            dfs(root);
            head.left = pre;
            pre.right = head;
            return head;
        }
        void dfs(Node cur)
        {
            if (cur == null) return;
            dfs(cur.left);
            if (pre != null) pre.right = cur;
            else head = cur;
            cur.left = pre;
            pre = cur;
            dfs(cur.right);
        }

        


    }
}

