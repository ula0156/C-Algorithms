using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class WithOutParam
    {
        public static int CountOddAndEven(int[] a, out int oddCount)
        {
            oddCount = 0;
            int evenCount = 0;
            foreach (int number in a)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                } else
                {
                    oddCount++;
                }
            }

            return evenCount;
        }
    }
}
