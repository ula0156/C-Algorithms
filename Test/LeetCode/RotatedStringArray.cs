using System;

namespace Test.LeetCode
{
    public class RotatedStringArray
    {
        private static int GetIndex(string[] a, int stInd, int endInd)
        {
            if (stInd >= endInd)
                return endInd;

            var midInd = (stInd + endInd) / 2;

            int compar = String.CompareOrdinal(a[stInd], a[midInd]);
            return (compar < 0) ? GetIndex(a, midInd, endInd) : GetIndex(a, stInd, midInd);
        }


        public static int FindRotatedIndex(string[] a)
        {
            if(a.Length == 0)
            {
                return -1;
            }

            return GetIndex(a, 0, a.Length - 1);
        } 
    }
}
