using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO24 : ISolution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public void Test()
        {
            var n1 = new ListNode(1);
            var n2 = new ListNode(2);
            n1.next = n2;

            var n3 = new ListNode(3);
            n2.next = n3;

            var n4 = new ListNode(4);
            n3.next = n4;
            ReverseList(n1);
        }
        public ListNode ReverseList(ListNode head)
        {
            ListNode fast = head, slow = null;
            while (fast != null)
            {
                var temp = fast.next;
                fast.next = slow;
                slow = fast;
                fast = temp;
            }
            return slow;
        }
    }
}

