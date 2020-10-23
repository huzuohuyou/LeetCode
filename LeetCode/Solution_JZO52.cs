using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO52 : ISolution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public void Test()
        {
            var n1 = new ListNode(4);
            var n2 = new ListNode(1);
            n1.next = n2;
            var n3 = new ListNode(8);
            n2.next = n3;
            var n4 = new ListNode(4);
            n3.next = n4;
            var n5 = new ListNode(5);
            n4.next = n5;


            var m1 = new ListNode(5);
            var m2 = new ListNode(0);
            m1.next = m2;
            var m3 = new ListNode(1);
            m2.next = m3;

            m3.next = n3;
            GetIntersectionNode(n1,m1);
        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var b = headB;
            while (headA != null)
            {

                if (headA.val==8)
                {

                }
                while (headB != null)
                {
                    if (headB.Equals(headA))
                    {
                        return headA;
                    }
                    headB = headB.next;

                }
                headB = b;
                headA = headA.next;
            }
            return null;
        }
        

    }
}

