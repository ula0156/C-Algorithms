using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.trees
{
    public static class IsWeighted
    {
        public static bool isWeighted(Node n, out int sum)
        {
            if (n == null)
            {
                sum = 0;
                return true;
            }
            int sumL;
            if (!isWeighted(n.Left, out sumL))
            {
                sum = -1;
                return false;
            }
            int sumR;
            if (!isWeighted(n.Right, out sumR))
            {
                sum = -1;
                return false;
            }
            sum = sumL + sumR + n.Data;
            if (sumL != sumR)
            {
                sum = -1;
                return false;
            }
            sum = sumL + sumR + n.Data;
            return true;
        }
    }
}
