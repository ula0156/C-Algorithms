using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class IsBinarySearchTree
    {
        public static bool IsBST(Node n)
        {
            if (n == null)
            {
                return true;
            }
            int min;
            int max;

            return _isBST(n, out min, out max);
        }

        private static bool _isBST(Node n, out int min, out int max)
        {
            min = n.Data;
            max = n.Data;
            if (n.Left != null)
            {
                int leftMin;
                int leftMax;
                if (!_isBST(n.Left, out leftMin, out leftMax)) {
                    return false;
                }
                if (leftMax > n.Data)
                {
                    return false;
                }
                min = leftMin;
            }
            if (n.Right != null)
            {
                int rightMin;
                int rightMax;
                if (!_isBST(n.Right, out rightMin, out rightMax))
                {
                    return false;
                }
                if (n.Data > rightMin)
                {
                    return false;
                }
                max = rightMax;
            }

            return true;
        }
    }
}
