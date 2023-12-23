using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class PairwiseNodeFlipper
    {
        public ListNode<int>? PairwiseFlip(ListNode<int> head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            var newHead = head.Next;
            ListNode<int> a = head;
            ListNode<int> b = head.Next;
            ListNode<int> prev = null;

            while (a != null && b != null)
            {
                a.Next = b.Next;
                b.Next = a;

                if (prev != null)
                    prev.Next = b;
                if (a.Next == null)
                    break;
                b = a.Next.Next;
                prev = a;
                a = a.Next;
            }

            return newHead;
        }

    }
}
