using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class MSort
    {
        public static void Merge(int[] a, int[] left, int[] right) {
            int i = 0; // left
            int j = 0; // right
            int k = 0; // main
            while (i < left.Length && j < right.Length)
            {
                if (left[i] > right[j])
                {
                    a[k] = right[j];
                    j++;
                } else
                {
                    a[k] = left[i];
                    i++;
                }

                k++;
            }

            while (i < left.Length)
            {
                a[k] = left[i];
                i++;
                k++;
            }
            while (j < right.Length)
            {
                a[k] = right[j];
                j++;
                k++;
            }
        }
        public static void MergeSort(int[] a)
        {
            if (a.Length == 1)
            {
                return;
            }
            int midInd = (int)(a.Length / 2);
            int[] left = new int[midInd - 0];
            Array.Copy(a, 0, left, 0, midInd - 0);
            int[] right = new int[a.Length - midInd];
            Array.Copy(a, midInd, right, 0, a.Length - midInd);
            MergeSort(left);
            MergeSort(right);
            Merge(a, left, right);
        }
    }
}
