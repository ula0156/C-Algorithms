using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.List
{
    public class RemoveDupFromLL
    {
        public static NodeLinkedList _RemoveDupFromLL(NodeLinkedList head)
        {
            NodeLinkedList runner = head;
            NodeLinkedList current = head;
            while (current != null)
            {
                while (runner.Next != null)
                {
                    if (current.Data == runner.Next.Data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }

                current = current.Next;
                runner = current;
            }

            return head;
        }
    }
}
