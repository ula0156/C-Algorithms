using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Permutations
{
    public class IncreasingPermutation
    {
         public static int[] GetPermut(int[] nums, int n)
        {
            if(nums.Length == 0 || n == 0)
            {
                new Exception("Invalid input");
            }

            var arr = new int[n];
            var result = new List<int[]>();
            FindPermutation(arr, 0, nums.Length, result);
            Random rnd = new Random();
            var index = rnd.Next(0, result.Count);
            return result[index];
        }

        private static void FindPermutation(int[] a, int pos, int k, List<int[]> result)
        {
            if(pos == a.Length)
            {
                int[] b = new int[a.Length];
                for (int j = 0; j < b.Length; j++)
                {
                    b[j] = a[j];
                }
                result.Add(b);
                return;
            }

            for(var i = pos + 1; i <= k - a.Length + (pos + 1); i++)
            {
                if(pos != 0)
                {
                    if(a[pos - 1] >= i)
                    {
                        i = a[pos - 1] + 1;
                    }
                }
                a[pos] = i;
                FindPermutation(a, pos + 1, k, result);
            }
        }
    }
}
