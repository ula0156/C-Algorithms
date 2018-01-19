using System;
using System.Linq;

namespace Test.GreedyApproach
{
    public class LongestIncreasingSubsequence
    {
        private static Tuple<int, int> GetValueForCountArr(int index, int[] a, int[] countArr, int[] numOfILS)
        {
            var indOfMaxILS = index - 1;
            var numOfWays = 0;
            var maxSoFar = 0;

            for (var j = index - 1; j >= 0; j--)
            {
                if (a[index] > a[j] && countArr[j] > maxSoFar)
                {
                    maxSoFar = countArr[j];
                    indOfMaxILS = j;
                }
            }

            for (var k = indOfMaxILS - 1; k >= 0; k--)
            {
                if (a[index] > a[k] && countArr[k] == maxSoFar)
                {
                    numOfWays += numOfILS[k];
                }
            }

            return new Tuple<int, int>(maxSoFar, numOfWays);
        }

        public static int FindNumberOfLIS(int[] a)
        {
            var max = 1;
            var countArr = Enumerable.Repeat(1, a.Length).ToArray();
            var numOfILS = Enumerable.Repeat(1, a.Length).ToArray();

            for (var i = 1; i < a.Length; i++)
            {
                var arraysResult = new Tuple<int, int>(0, 0);
                arraysResult = GetValueForCountArr(i, a, countArr, numOfILS);
                countArr[i] = arraysResult.Item1 + 1;
                numOfILS[i] = arraysResult.Item2;

                if (max < countArr[i])
                {
                    max = countArr[i];
                }
            }
            var result = 0;
            for (var j = 0; j < countArr.Length; j++)
            {
                if (countArr[j] == max)
                {
                    result += numOfILS[j];
                }
            }

            return result;
        }
    }
}
