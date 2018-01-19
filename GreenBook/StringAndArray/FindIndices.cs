using System;

namespace GreenBook.StringAndArray
{
    public class FindIndices
    {
        public static Tuple<int, int> FindIndicesToSort(int[] a)
        {
            var min_index = a.Length;
            var max_index = 0;

            var max = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                
                    if (a[i] < max)
                    {
                        min_index = Math.Min(min_index, i);
                        max_index = Math.Max(max_index, i);
                    }
                    else
                    {
                        max = a[i];
                    }
            }

            var min = a[a.Length - 1];

            for (int j = a.Length - 1; j >= 0; j--)
            {
                if (a[j] > min)
                {
                    max_index = Math.Max(max_index, j);
                    min_index = Math.Min(min_index, j);
                }
                else
                {
                    min = a[j];
                }
            }

            return new Tuple<int, int>(min_index, max_index);
        }
    }
}
