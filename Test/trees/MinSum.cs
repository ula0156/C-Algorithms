using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.trees
{
    public class MinSum
    {
        public static int minSum(Node n)
        {
            if (n.Left != null && n.Right != null)
            {
                return Math.Min(minSum(n.Left), minSum(n.Right)) + n.Data;
            }
            if (n.Left != null && n.Right == null)
            {
                return minSum(n.Left) + n.Data;
            }
            if (n.Right != null && n.Left == null)
            {
                return minSum(n.Right) + n.Data;
            }

            return n.Data;
        }
    }
}
