using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public static class MagicIndex
    {
        //	3. A magic index in an array A[0…n-1] is defined to be an index such that A[i] = i.
        // Given a sorted array of distinct integers, write a method to find a magic index if one exists, in an array A.
        // FOLLOW UP: What if the values are not distinct?

        public static int _MagicIndex(int[] a, int stInd, int endInd)
        {
            if (stInd > endInd)
            {
                return -1; // it means - no such index exist 
            }

            var midInd = (stInd + endInd) / 2;

            if (midInd == a[midInd])
            {
                return midInd;
            }

            if (midInd > a[midInd])
            {
                return _MagicIndex(a, midInd + 1, endInd);
            }
            // if midInd < a[midIndex]
            return _MagicIndex(a, stInd, midInd - 1);
        }

        // FOLLOW UP - if values are not distinct -> iterate through entire array 0(n);
    }
}
