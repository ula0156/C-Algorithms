using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Node
    {
        public Node Left;
        public Node Right;
        public int Data;

        public Node(int data)
        {
            Data = data;       
        }

        public Node(int data, Node left, Node right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
    }
}
