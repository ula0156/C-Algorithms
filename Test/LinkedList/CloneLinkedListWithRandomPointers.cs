using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class CloneLinkedListWithRandomPointers
    {
        public static NodeLinkedList _cloneLL(NodeLinkedList head)
        {
            NodeLinkedList current = head;
            NodeLinkedList previous = null;
            while (current != null)
            {
                previous = current;
                current = current.Next;
                previous.Next = new NodeLinkedList(previous.Data);
                previous.Next.Next = current;
            }
            current = head;
            NodeLinkedList head2 = current.Next;
            NodeLinkedList current2 = head2;
            while (current2.Next != null)
            {
                // rendom pointer for the node of clone list
                current2.Random = current.Random.Next;
                // set the next pointer for original list
                current.Next = current2.Next;
                // set the next pointer for clone list
                current2.Next = current.Next.Next;
                // modify current to the next node on the original list
                current = current.Next;
                // modify current2 to the next node ont clone list
                current2 = current.Next;
            }

            return head2;
        }
    }
}
