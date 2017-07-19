using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class NodeLinkedList
    {
        public int Data { get; set; }
        public NodeLinkedList Next { get; set; }
        public NodeLinkedList Random { get; set; }
        
        public NodeLinkedList(int data)
        {
            Data = data;
        }
       
        public NodeLinkedList(int data, NodeLinkedList next, NodeLinkedList random) 
        {
            Data = data;
            Next = next;
            Random = random;
        }
    }
}
