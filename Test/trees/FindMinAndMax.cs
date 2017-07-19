using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class FindMinAndMax
    {
        // Assume that n != null;
        public static int _findMinAndMax(Node n, out int max)
        {
            int min = n.Data;
            max = n.Data;

            if (n.Left != null)
            {
                int leftMax;
                int leftMin = _findMinAndMax(n.Left, out leftMax);

                max = Math.Max(leftMax, max);
                min = Math.Min(leftMin, min);
            }

            if (n.Right != null)
            {
                int rightMax;
                int rightMin = _findMinAndMax(n.Right, out rightMax);

                max = Math.Max(rightMax, max);
                min = Math.Min(rightMin, min);
            }

            return min;
            /*
            if (n.Left != null && n.Right != null)
            {
                int leftMax;
                int leftMin = _findMinAndMax(n.Left, out leftMax);

                int rightMax;
                int rightMin = _findMinAndMax(n.Right, out rightMax);

                max = Math.Max(Math.Max(leftMax, rightMax), n.Data);
                return Math.Min(Math.Min(leftMin, rightMin), n.Data);
            }
            if (n.Right == null && n.Left != null)
            {
                int leftMax;
                int leftMin = _findMinAndMax(n.Left, out leftMax);

                max = Math.Max(leftMax, n.Data);
                return Math.Min(leftMin, n.Data); 
            }
            if (n.Left == null && n.Right != null)
            {
                int rightMax;
                int rightMin =_findMinAndMax(n.Right, out rightMax);
                max = Math.Max(rightMax, n.Data);
                return Math.Min(rightMin, n.Data);
            }
            max = n.Data;
            return n.Data;*/
        }
    }
}
