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
            if (endInd - stInd < 3)
            {
                if (a[stInd] == a[stInd] + 1)
                {
                    return a[endInd];
                } else
                {
                    return a[stInd];
                }
            }

            int midInd = (int)((stInd + endInd) / 2) + stInd;   // why (int)Math.Floor() - didn't work?????

            if (a[midInd] == a[midInd - 1])
            {
                // unique number is on the left
                return FindUniqueNumber(a, stInd, midInd);
            } else if (a[midInd] == a[midInd + 1])
            {
                // unique number is on the right
                return FindUniqueNumber(a, midInd, a.Length - 1);
            } else
            {
                // unique number is a at midIn;
                return a[midInd];
            }
        }
    }
}
