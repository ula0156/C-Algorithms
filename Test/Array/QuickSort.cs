using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public class QuickSort
    {
        public static void QuickSorts(int[] a, int stInd, int endInd)
        {
            var pivInd = stInd;

            if (stInd >= endInd)
            {
                return;
            }

            for (var i = stInd + 1; i < endInd; i++)
            {
                if (a[i] < a[pivInd])
                {
                    var piv = a[pivInd];
                    if (i == pivInd + 1)
                    {
                        a[pivInd] = a[i];
                        a[i] = piv;
                        pivInd = i;
                    }
                    else
                    {
                        a[pivInd] = a[i];
                        a[i] = a[pivInd + 1];
                        a[pivInd + 1] = piv;
                        pivInd = pivInd + 1;
                    }
                }
            }

            QuickSorts(a, pivInd + 1, endInd);
            QuickSorts(a, stInd, pivInd);
        }

        public static int ArrayPairSum(int[] nums)
        {
            QuickSorts(nums, 0, nums.Length);

            var sum = 0;
            for (var j = 0; j < nums.Length; j += 2)
            {
                sum += nums[j];
            }

            return sum;
        }
    }
}
