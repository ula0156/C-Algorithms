using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SecondSmallest
    {
        public static bool TryGetSecondSmallest(int[] a, out int secondSmallest)
        {
            secondSmallest = 0;
            if ( a.Length < 2)
            {
                return false;
            } 

            int smallest = a[0];
            secondSmallest = a[1];
            for (var i = 1; i < a.Length; i++)
            {
                if (a[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = a[i];
                }
                else if (secondSmallest > a[i] && smallest != a[i])
                {
                    secondSmallest = a[i];
                }
            }

            if (smallest == secondSmallest)
            {
                return false;
            }

            return true;
        }
        
    }
}

