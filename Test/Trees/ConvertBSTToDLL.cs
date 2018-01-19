using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Trees
{
    public class ConvertBSTToDLL
    {
        static Node previous = null;

        private static void Convert(Node n, ref Node head)
        {
            if (n == null)
            {
                return;
            }

            // 1 step - in-order traversal (left subtree)
            Convert(n.Left, ref head);

            // 2 step - process node
            if(head == null)
            {
                head = n;
            }

            else
            {
                n.Left = previous;
                previous.Right = n;
            }

            previous = n;

            // 3 step - in-order traversal (right subtree)
            Convert(n.Right, ref head);
        }


        public static Node ConvertBSTToDoubleLinkList(Node root)
        {
            if(root == null)
            {
                return null;
            }

            Node head = null;
            Convert(root, ref head);

            return head;
        }
    }
}
