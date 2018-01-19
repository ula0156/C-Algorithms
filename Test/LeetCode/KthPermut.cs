using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LeetCode
{
    public class KthPermut
    {
        private static void Perm(int[] a, int pos, int k, HashSet<int> hs, ref int count, ref StringBuilder result)
        {
            if (pos == a.Length)
            {
                count++;

                if (count == k)
                {
                    foreach (var item in a)
                    {
                        result.Append(Convert.ToChar('0' + item));
                    }
                }

                return;
            }

            for (var i = 1; i <= a.Length; i++)
            {
                if (!hs.Contains(i))
                {
                    a[pos] = i;
                    hs.Add(i);
                    Perm(a, pos + 1, k, hs, ref count, ref result);
                    hs.Remove(a[pos]);
                }
            }
        }

        public static string GetPermutation(int n, int k)
        {
            var a = new int[n];
            var hs = new HashSet<int>();
            var count = 0;
            StringBuilder result = new StringBuilder();
            Perm(a, 0, k, hs, ref count, ref result);
            return result.ToString();
        }
    }
}
