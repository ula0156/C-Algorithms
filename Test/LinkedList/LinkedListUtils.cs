using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class LinkedListUtils
    {
        public static NodeLinkedList CreateLinkedList(int[] items)
        {
            NodeLinkedList head = null;
            NodeLinkedList current = null;
            for (int i = 0; i < items.Length; i++)
            {
                if(head == null)
                {
                    head = new NodeLinkedList(items[i]);
                    current = head;
                }
                else
                {
                    current.Next = new NodeLinkedList(items[i]);
                    current = current.Next;
                }
            }

            createRandomPointers(head);
            return head;
        }

         public static void createRandomPointers(NodeLinkedList head)
        {
            var current = head;
            current.Random = current.Next.Next;
            current = current.Next;

            current.Random = current;
            current = current.Next;

            current.Random = current.Next.Next;
            current = current.Next;

            current.Random = head;
            current = current.Next;

            current.Random = current;
        }

    }
}
