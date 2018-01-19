using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook.StringAndArray
{
    public static class OneDup
    {
        public static int _OneDup(int[] a, int n)
        {
            var expectedSum = 0;
            // TODO - strange code formatting
            // TODO - There is a formula to calculate this
            while (n > 0)
                {
                    expectedSum += n - 1;
                    n--;
                }

            var actualSum = 0;
            for (var i = 0; i < a.Length; i++)
            {
                actualSum += a[i];
            }

            return actualSum - expectedSum;
        }
    }
}
