using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LeetCode
{
    public class ReplaceDigits2
    {
        private void MakeSwap(List<int> digitArr, int[] resultArr)
        {
            var j = 0;
            var numberToSwap = -1;
            for (; j < digitArr.Count; j++)
            {
                if (resultArr[j] > -1)
                {
                    numberToSwap = digitArr[resultArr[j]];
                    break;
                }
            }

            if (numberToSwap > -1)
                for (var k = digitArr.Count - 1; k >= 0; k--)
                {
                    if (digitArr[k] == digitArr[resultArr[j]])
                    {
                        var tmp = digitArr[k];
                        digitArr[k] = digitArr[j];
                        digitArr[j] = tmp;
                        break;
                    }
                }
        }

        private List<int> ConverToArray(int num)
        {
            var digits = new List<int>();
            while (num > 0)
            {
                digits.Add(num % 10);
                num /= 10;
            }

            digits.Reverse();

            return digits;
        }

        private int ConverToInt(List<int> digitArr)
        {
            int resultNum = 0;

            foreach (var digit in digitArr)
            {
                resultNum = resultNum * 10 + digit;
            }

            return resultNum;
        }

        public int MaximumSwap(int num)
        {
            var digitArr = ConverToArray(num);
            var resultArr = new int[digitArr.Count];

            resultArr[resultArr.Length - 1] = -1;

            for (var i = digitArr.Count - 2; i >= 0; i--)
            {
                if (digitArr[i] < digitArr[i + 1])
                {
                    if (resultArr[i + 1] == -1)
                    {
                        resultArr[i] = i + 1;
                    }
                    else
                    {
                        resultArr[i] = resultArr[i + 1];
                    }
                }
                else
                {
                    if (resultArr[i + 1] == -1)
                    {
                        resultArr[i] = -1;
                    }
                    else if (digitArr[resultArr[i + 1]] > digitArr[i])
                    {
                        resultArr[i] = resultArr[i + 1];
                    }
                    else
                    {
                        resultArr[i] = -1;
                    }
                }
            }

            MakeSwap(digitArr, resultArr);

            return ConverToInt(digitArr);
        }
    }
}
