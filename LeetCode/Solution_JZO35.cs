using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    /// <summary>
    /// 复杂链表的复制
    /// </summary>
    public class Solution_JZO35 : ISolution
    {

        public void Test()
        {
            var node7 = new Node(7);
            var node13 = new Node(13);
            var node11 = new Node(11);
            var node10 = new Node(10);
            var node1 = new Node(1);
            node7.next = node13;
            node7.random = null;
            node13.next = node11;
            node13.random = node7;
            node11.next = node10;
            node11.random = null;
            node10.next = node1;
            node10.random = node11;
            node1.next = null;
            node1.random = node7;
            CopyRandomList(node7);
        }
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;
            Node cur = head;
            var map = new Dictionary<Node, Node>();
            // 3. 复制各节点，并建立 “原节点 -> 新节点” 的 Map 映射
            while (cur != null)
            {
                map.Add(cur, new Node(cur.val));
                cur = cur.next;
            }
            cur = head;
            // 4. 构建新链表的 next 和 random 指向
            while (cur != null)
            {
                Node curValue;
                map.TryGetValue(cur,out curValue);
                curValue.next = cur.next == null ? null : map[cur.next];
                curValue.random =cur.random==null?null: map[cur.random];
                cur = cur.next;
            }
            // 5. 返回新链表的头节点
            return map[head];
        }
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }








        }
    }
}
