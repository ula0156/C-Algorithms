using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class QSort
    {
        public static void QuickSort(int[] a, int stInd, int endInd)
        {
            if (stInd >= endInd)
            {
                return;
            }
            int pivotInd = stInd;

            for (int i = 0; i <= endInd; i++)
            {
                if (a[pivotInd] > a[i])
                {
                    if (i == pivotInd + 1)
                    {
                        int tmp = a[pivotInd];
                        a[pivotInd] = a[i];
                        a[i] = tmp;
                        pivotInd = i;
                    }
                    else
                    {
                        int tmp = a[pivotInd];
                        a[pivotInd] = a[i];
                        a[i] = a[pivotInd + 1];
                        a[pivotInd + 1] = tmp;
                        pivotInd = pivotInd + 1;
                    }
                }
            }

            QuickSort(a, stInd, pivotInd - 1);
            QuickSort(a, pivotInd + 1, endInd);
        }
    }
}
