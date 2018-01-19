using System;
using System.Collections.Generic;

namespace Test.LeetCode
{
    public class ReplaceDigits
    {
        /**
         * Replace digits in positive num -> to make it bigger. Can swap the most 2 digits.
         */
        private static List<int> ConverToArray(int num)
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

        private static int ConverToInt(List<int> digitArr)
        {
            int resultNum = 0;

            for (int k = 0; k < digitArr.Count; k++)
            {
                resultNum += digitArr[k] * (int)Math.Pow(10, (digitArr.Count - 1) - k);
            }

            return resultNum;
        }

        public static int MaximumSwap(int num)
        {
            var digitArr = ConverToArray(num);
            var resultArr = new int[digitArr.Count];

            var stack = new Stack<Tuple<int, int>>();
            var max = new Stack<Tuple<int, int>>();

            resultArr[digitArr.Count - 1] = -1;
            stack.Push(new Tuple<int, int>(digitArr[digitArr.Count - 1], digitArr.Count - 1));
            max.Push(new Tuple<int, int>(digitArr[digitArr.Count - 1], digitArr.Count - 1));
            var firstToSwap = new Tuple<int, int>(-1, -1);


            for (var i = digitArr.Count - 2; i >= 0; i--)
            {
                if (digitArr[i] < stack.Peek().Item1)
                {
                    resultArr[i] = stack.Peek().Item2;
                    stack.Push(new Tuple<int, int>(digitArr[i], i));
                    firstToSwap = new Tuple<int, int>(digitArr[i], i);
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        if (digitArr[i] < stack.Peek().Item1)
                        {
                            resultArr[i] = stack.Peek().Item2;
                            firstToSwap = new Tuple<int, int>(digitArr[i], i);
                            break;
                        }

                        stack.Pop();
                    }

                    if (stack.Count == 0)
                    {
                        if (max.Peek().Item1 < digitArr[i])
                        {
                            max.Push(new Tuple<int, int>(digitArr[i], i));
                        }
                        resultArr[i] = -1;
                        stack.Push(new Tuple<int, int>(digitArr[i], i));
                    }
                }

            }

            if (firstToSwap.Item1 > -1)
            {
                while (max.Count > 0)
                {
                    if (max.Peek().Item2 > firstToSwap.Item2)
                    {
                        var tmp = digitArr[firstToSwap.Item2];
                        digitArr[firstToSwap.Item2] = digitArr[max.Peek().Item2];
                        digitArr[max.Peek().Item2] = tmp;
                        break;
                    }

                    max.Pop();
                }
                
            }

            return ConverToInt(digitArr);
        }
    }
}
