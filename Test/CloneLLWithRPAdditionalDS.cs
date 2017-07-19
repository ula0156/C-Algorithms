using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class CloneLLWithRPAdditionalDS
    {
        public static NodeLinkedList _CloneLLWithRPAdditionalDS(NodeLinkedList head)
        {
            Dictionary<NodeLinkedList, NodeLinkedList> LL = new Dictionary<NodeLinkedList, NodeLinkedList>();
            NodeLinkedList current = head;
            NodeLinkedList headClone = null;
            NodeLinkedList currentClone = null;
            NodeLinkedList previous = null;
            
            while(current != null)
            {
                previous = current;
                current = current.Next;
                if (currentClone == null) // or it's better to use headClone??
                {
                    headClone = new NodeLinkedList(previous.Data);
                    currentClone = headClone;
                }
                else
                {
                    currentClone.Next = new NodeLinkedList(previous.Data);
                }
                LL.Add(previous, currentClone);
            }

            current = head;
            currentClone = head;
            while (current != null)
            {
                // Get the node randomPointer from the original List
                var nodeRandomPointerInOriginalList = current.Random;
                currentClone.Random = LL[nodeRandomPointerInOriginalList];
                current = current.Next;
                currentClone = currentClone.Next;
            }

            return headClone;
        }
    }
}
