using System;

namespace Test.DynamicProgramming
{
    public class MaxProductOfThree
    {
        public static int GetMaxProductOfThree(int[] a)
        {
            if (a.Length < 3)
            {
                return 0;
            }

            var minPOf1 = Math.Min(Math.Max(a[0], a[1]), a[2]);
            var maxPOf1 = Math.Max(Math.Max(a[0], a[1]), a[2]);
            var maxPOf2 = Math.Max(Math.Max(a[0] * a[1], a[0] * a[2]), a[2] * a[1]);
            var minPOf2 = Math.Min(Math.Min(a[0] * a[1], a[0] * a[2]), a[2] * a[1]);
            var maxPOf3 = a[0] * a[1] * a[2];

            for (var i = 3; i < a.Length; i++) 
            {
                maxPOf3 = Math.Max(Math.Max(minPOf2 * a[i], maxPOf2 * a[i]), maxPOf3);
                minPOf2 = Math.Min(Math.Min(minPOf1 * a[i], maxPOf1 * a[i]), minPOf2);
                maxPOf2 = Math.Max(Math.Max(minPOf1 * a[i], maxPOf1 * a[i]), maxPOf2);
                minPOf1 = Math.Min(minPOf1, a[i]);
                maxPOf1 = Math.Min(maxPOf1, a[i]);
            }
            return maxPOf3;
        }
    }
}
