using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.trees
{
    public static class TreeUtils
    {
        public static Node CreateBalancedBinaryTreeFromArray(List<int> items)
        {
            return CreateBalancedBinaryTree(items, 0, items.Count - 1);
        }

        private static Node CreateBalancedBinaryTree(List<int> items, int stInd, int endInd)
        {
            if (stInd > endInd)
            {
                return null;
            }
            int midInd = (stInd + endInd) / 2;
            Node n = new Node(items[midInd]);
            n.Left = CreateBalancedBinaryTree(items, stInd, midInd - 1);
            n.Right = CreateBalancedBinaryTree(items, midInd + 1, endInd);

            return n;
        }
    }
}
