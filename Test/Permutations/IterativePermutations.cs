using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Permutations
{
    public static class IterativePermutations
    {
        public static List<int[]> Permutations(int[] a, int pos, int k)
        {
            List<int[]> result = new List<int[]>();
            while (pos > -1)
            {
                if (a[pos] == k - 1)
                {
                    a[pos] = -1;
                    pos--;
                }
                else if (a[pos] < k - 1)
                {
                    a[pos]++;
                    pos++;
                }
                if (pos == a.Length)
                {
                    pos--;
                    int[] copy = new int[a.Length];
                    a.CopyTo(copy, 0);
                    result.Add(copy);
                }
            }

            return result;
        }
    }
}
