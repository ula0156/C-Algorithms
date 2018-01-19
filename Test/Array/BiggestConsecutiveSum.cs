using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public static class BiggestConsecutiveSum
    {
        public static int _BiggestConsecutiveSum(int[] a)
        {
            var maxSum = a[0];
            var single = a[0];
            var sum = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                single = a[i];
                sum += single;
                if (sum < single)
                {
                    sum = single;
                }
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum;
        }
    }
}
