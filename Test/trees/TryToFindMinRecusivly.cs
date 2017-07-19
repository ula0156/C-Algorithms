using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TryToFindMinRecusivly
    {
        public static bool TryFindMin(Node n, out int min)
        {
            if (n == null)
            {
                min = 0;
                return false;
            }
            min = n.Data;

            int leftMin;
            if (TryFindMin(n.Left, out leftMin))
            {
                min = Math.Min(min, leftMin);
            }

            int rightMin;
            if (TryFindMin(n.Right, out rightMin))
            {
                min = Math.Min(rightMin, min);
            }

            return true;
        }
    }
}
