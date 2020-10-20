using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO25 : ISolution
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

            var m1 = new ListNode(2);
            var m2 = new ListNode(4);
            n1.next = m2;

            var m3 = new ListNode(5);
            n2.next = m3;

            var m4 = new ListNode(6);
            n3.next = m4;
            MergeTwoLists(n1,m1);
        }
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var dum = new ListNode(0); ListNode cur = dum;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }
            cur.next = l1==null?l2:l1;
            return dum.next;
        }
    }
}

