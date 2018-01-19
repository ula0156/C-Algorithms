using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public static class FindElementInRotatedArray
    {
        public static int _FindElementInRotatedArray(int[] a, int n, int stInd, int endInd)
        {
            if (stInd > endInd)
            {
                return -1;
            }
            var midInd = (stInd + endInd) / 2;

            if (n == a[midInd])
            {
                return midInd;
            }

            if (n > a[midInd])
            {
                if (n > a[a.Length - 1])
                {
                    return _FindElementInRotatedArray(a, n, stInd, midInd - 1);
                }
                else if (n < a[a.Length - 1])
                {
                    return _FindElementInRotatedArray(a, n, midInd + 1, a.Length - 1);

                }
            }
            else if(n < a[midInd])
            {
                if (n < a[stInd])
                {
                    return _FindElementInRotatedArray(a, n, midInd + 1, a.Length -1);
                }
                else if (n > a[stInd])
                {
                    return _FindElementInRotatedArray(a, n, midInd + 1, a.Length - 1);

                }
            }

            return -1;
        }
    }
}
