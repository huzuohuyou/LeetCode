using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO22 : ISolution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public void Test()
        {
            
        }
        public ListNode GetKthFromEnd(ListNode head, int k)
        {
            ListNode fast = head, slow = head;
            for (int i = 0; i < k; i++)
            {
                fast = fast.next;
            }
            while (fast!=null)
            {
                fast = fast.next;
                slow = slow.next;
            }return slow;
        }
    }
}

