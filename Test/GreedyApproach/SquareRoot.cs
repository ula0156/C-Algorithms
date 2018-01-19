using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class SquareRoot
    {
        public static int FindSquareRoot(int n, int st, int end)
        {
            if (st == end - 1)
            {
                return st;
            }
            int mid = (st + end) / 2;

            if (mid * mid == n)
            {
                return mid;
            }

            if ((mid * mid) > n)
            {
                return FindSquareRoot(n, st, mid);
            }

            return FindSquareRoot(n, mid, end);
        }
    }
}
