using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO18 : ISolution
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
            var n2 = new ListNode(5);
            n1.next = n2;

            var n3 = new ListNode(1);
            n2.next = n3;

            var n4 = new ListNode(9);
            n3.next = n4;

           
            var f = DeleteNode(n1,4);
        }
        public ListNode DeleteNode(ListNode head, int val)
        {
            
            var stack = new Stack<ListNode>();
            while (head!=null)
            {
                if (val==head.val)
                {
                    if (stack.Count > 0 )
                    {
                        var pre = stack.Pop();
                        pre.next = head.next;
                        head = pre;
                        break;
                    }
                    
                }
                else
                {
                    stack.Push(head);
                }
                
                head = head.next;
                
            }

            return stack.Count > 0 ? stack.Last() : head ;
        }
    }
}

