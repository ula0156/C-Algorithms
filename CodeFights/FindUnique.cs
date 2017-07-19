using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class FindUnique
    {
        public static int FindUniqueNumber(int[] a, int stInd, int endInd)
        {
            if (stInd == endInd)
            {
                return a[stInd];
            }

            int midInd = (stInd + endInd) / 2; 

            if (a[midInd] == a[midInd - 1])
            {
                // unique number is on the left
                if (((midInd - 1) - stInd) % 2 == 1) {
                    return FindUniqueNumber(a, stInd, midInd - 2);
                } else
                {
                    return FindUniqueNumber(a, midInd + 1, endInd);
                }
            }
            else if (a[midInd] == a[midInd + 1])
            {
                // unique number is on the right
                if ((endInd - (midInd + 1)) % 2 == 1)
                {
                    return FindUniqueNumber(a, midInd + 2, a.Length - 1);
                } else
                {
                    return FindUniqueNumber(a, stInd, midInd - 1);
                }
            }
            else
            {
                // unique number is a at midIn;
                return a[midInd];
            }
        }
    }
}
