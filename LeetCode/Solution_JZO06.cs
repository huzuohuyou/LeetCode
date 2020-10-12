using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO06 : ISolution
    {
        public void Test()
        {
            var head = new ListNode(1);
            
            var n1 = new ListNode(2);
            head.next = n1;
            var n2 = new ListNode(3);
            n1.next = n2;
            var a = ReversePrint(head);
            //var x = FindRepeatNumber(new int[] { 1, 0, 3, 5, 9, 12 });
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public int[] ReversePrint(ListNode head)
        {
            Recursion(head);
            var array = new int[queue.Count];
            
            for (int i = 0; i < array.Length; i++)
            {
                var n = queue.Dequeue();
                array[i] = n.val;
            }
            return array;

        }
        Queue<ListNode> queue = new Queue<ListNode>();
        public void Recursion(ListNode head) {
            
            if (head.next==null)
            {
                queue.Enqueue(head);
                return ;
            }
            else
            {
                Recursion(head.next);
                queue.Enqueue(head);
                return;
            }
            
        }

      
    }
}
