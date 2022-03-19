using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class Q876MiddleOfTheLinkedList
    {
        public void Solution()
        {

        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode MiddleNode(ListNode head)
        {
            ListNode[] A = new ListNode[100];
            int t = 0;
            while (head != null)
            {
                A[t++] = head;
                head = head.next;
            }
            return A[t / 2];
        }
    }
}
