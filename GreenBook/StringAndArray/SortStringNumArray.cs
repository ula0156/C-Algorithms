using System;

namespace GreenBook.StringAndArray
{
    public class SortStringNumArray
    {
        static public void Sort(string[] unsorted)
        {
            if (unsorted.Length > 1)
            {
                //sort an unsorted array by length
                SortArray(unsorted, 0, unsorted.Length - 1);

                //iterate over partially sorted array, looking for the interval to sort
                var stInd = 0;
                for (var j = 1; j < unsorted.Length; j++)
                {
                    if (j == unsorted.Length - 1 && unsorted[j].Length == unsorted[j - 1].Length)
                    {
                        SortPartionalArray(unsorted, stInd, j);
                        break;
                    }
                    else if (unsorted[j].Length != unsorted[j - 1].Length)
                    {
                        SortPartionalArray(unsorted, stInd, j - 1);
                        stInd = j;
                    }

                }

            }

            //print the result after sorting an array
            foreach (var element in unsorted)
            {
                Console.WriteLine(element);
                System.Diagnostics.Debug.WriteLine(element);
            }
        }

        static private void SortPartionalArray(string[] unsorted, int stInd, int endInd)
        {
            if (stInd >= endInd)
            {
                return;
            }

            var pivInd = stInd;
            for (int k = stInd; k <= endInd; k++)
            {
                var val = String.CompareOrdinal(unsorted[pivInd], unsorted[k]);
                if (val > 0)
                {
                    if (pivInd + 1 == k)
                    {
                        var tmp = unsorted[pivInd];
                        unsorted[pivInd] = unsorted[k];
                        unsorted[k] = tmp;
                        pivInd = k;
                    }
                    else
                    {
                        var tmp = unsorted[pivInd];
                        unsorted[pivInd] = unsorted[k];
                        unsorted[k] = unsorted[pivInd + 1];
                        unsorted[pivInd + 1] = tmp;
                        pivInd = pivInd + 1;
                    }
                }
            }
            

            SortPartionalArray(unsorted, stInd, pivInd - 1);
            SortPartionalArray(unsorted, pivInd + 1, endInd);
        }

        // sort an array by length
        static private void SortArray(string[] unsorted, int stInd, int endInd)
        {
            if (stInd >= endInd)
            {
                return;
            }

            var piv = endInd;
            for (int i = endInd; i >= stInd; i--)
            {
                if (unsorted[i].Length > unsorted[piv].Length)
                {
                    if (piv - 1 == i)
                    {
                        var tmp = unsorted[piv];
                        unsorted[piv] = unsorted[i];
                        unsorted[i] = tmp;
                        piv = i;
                    }
                    else
                    {
                        var tmp = unsorted[piv];
                        unsorted[piv] = unsorted[i];
                        unsorted[i] = unsorted[piv - 1];
                        unsorted[piv - 1] = tmp;
                        piv = piv - 1;
                    }
                }
            }

            SortArray(unsorted, piv + 1, endInd);
            SortArray(unsorted, stInd, piv - 1);
        }
    }

}