using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class CountPeaks
    {
        public static int GetNumOfPeaks(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                bool isPeak = true;
                if (i > 0 && a[i - 1] >= a[i])
                {
                    isPeak = false;
                }

                if (i < a.Length - 1 && a[i + 1] >= a[i])
                {
                    isPeak = false;
                }

                if (isPeak)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
