using System;
using System.Collections.Generic;

namespace Test.Recusion
{
    public static class NumPermutations
    {
        public static void _NumPermutations(int[] a, int pos, int k)
        {
            if (pos == a.Length)
            {
                Console.WriteLine(a);
                return;
            }
            for (var i = 0; i < k; i++)
            {
                a[pos] = i;
                _NumPermutations(a, pos + 1, k);
            }
        }

        public static void _NumPermutations2(List<int> a, int pos, int k)
        {
            if (pos == k)
            {
                Console.WriteLine(a);;
                return;
            }
            for (var i = 0; i < k; i++)
            {
                a.Add(i);
                _NumPermutations2(a, pos + 1, k);
                a.RemoveAt(pos);
            }
        }
    }
}
