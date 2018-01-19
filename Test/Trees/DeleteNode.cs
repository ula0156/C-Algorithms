using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Trees
{
    public class DeleteNode
    {
        private static Node TryToFindNodeToDelete(Node n, int data, ref Node parent)
        {
            if (n == null)
            {
                return null;
            }

            if (n.Data == data)
            {
                return n;
            }

            parent = n;
            if (n.Data > data)
            {
                return TryToFindNodeToDelete(n.Left, data, ref parent);
            } else
            {
                return TryToFindNodeToDelete(n.Right, data, ref parent);
            }
        }

        private static void Delete(Node parent, Node toDeleteNode)
        {
            if (toDeleteNode.Right == null)
            {
                if (parent.Right == toDeleteNode)
                {
                    parent.Right = toDeleteNode.Left;
                } else
                {
                    parent.Left = toDeleteNode.Left;
                }
            }

            else if (toDeleteNode.Left == null)
            {
                if (parent.Right == toDeleteNode)
                {
                    parent.Right = toDeleteNode.Right;
                }
                else
                {
                    parent.Left = toDeleteNode.Right;
                }
            } else
            {
                if (parent.Right == toDeleteNode)
                {
                    parent.Right = toDeleteNode.Right;
                    var current = toDeleteNode.Right;
                    while(current.Left != null)
                    {
                        current = current.Left;
                    }
                    current.Left = parent.Left;
                    parent.Left = toDeleteNode.Left;
                }
                else
                {
                    parent.Left = toDeleteNode.Right;
                    var current = toDeleteNode.Right;
                    while(current.Left != null)
                    {
                        current = current.Left;
                    }
                    current.Left = toDeleteNode.Left;

                }
            }
        }

        public static void DeleteNodeFromBST(Node n, int data)
        {
            var parent = n;
            var toDelete = TryToFindNodeToDelete(n, data, ref parent);
            if(toDelete == null)
            {
                return;
            }

            Delete(parent, toDelete);
        }
    }
}
