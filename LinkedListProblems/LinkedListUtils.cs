using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblems
{
    public class LinkedListUtils<T>
    {
        public void PrintList(ListNode<T> current)
        {
            ListNode<T> c = current;
            while (c != null)
            {
                Console.Write(c.Value + " ");
                c = c.Next;
            }
            Console.WriteLine();
        }
    }
}
