using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SplitArrayInto2
    {
        public static Tuple<int[], int[]> SplitArray(int[] a)
        {
            int[] b = new int[1];
            int[] c = new int[a.Length - 2];
            int sum = 0;
            foreach (int number in a)
            {
                sum += number;
            }

            b[0] = sum / 2;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[0])
                {
                    c[i] = a[i];
                }
            }
       
            return new Tuple<int[], int[]> (b, c);
        }
    }
}
