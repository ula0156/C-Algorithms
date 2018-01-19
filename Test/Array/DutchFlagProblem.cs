using System;
using System.Collections.Generic;

namespace Test.Array
{
    public class DutchFlagProblem
    {
        private static void SortArray(int[]a, List<Tuple<int, int>> list)
        {
            var j = 0;
            foreach (var item in list)
            {
                var count = item.Item2;
                while (count > 0)
                {
                    a[j] = item.Item1;
                    j++;
                    count--;
                }
            }
        }

        public static void Sort(int[] a)
            {
            var firstNum = new Tuple<int, int>(a[0], 1);
            var secondNum = new Tuple<int, int>(-1, 0);
            var thirdNum = new Tuple<int, int>(-1, 0);

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] == firstNum.Item1)
                {
                    var tmp = firstNum;
                    firstNum = new Tuple<int, int>(a[i], tmp.Item2 + 1);
                }

                else if (a[i] == secondNum.Item1)
                {
                    var tmp = secondNum;
                    secondNum = new Tuple<int, int>(a[i], tmp.Item2 + 1);
                }

                else if (a[i] == thirdNum.Item1)
                {
                    var tmp = thirdNum;
                    thirdNum = new Tuple<int, int>(a[i], tmp.Item2 + 1);
                }

                else if (secondNum.Item2 == 0)
                {
                    if (firstNum.Item1 > a[i])
                    {
                        var tmp = firstNum;
                        firstNum = new Tuple<int, int>(a[i], 1);
                        secondNum = tmp;
                    }

                    else
                    {
                        secondNum = new Tuple<int, int>(a[i], 1);
                    }
                }
                else if (thirdNum.Item2 == 0)
                {
                    if (a[i] < firstNum.Item1)
                    {
                        var tmp = firstNum;
                        firstNum = new Tuple<int, int>(a[i], 1);
                        thirdNum = secondNum;
                        secondNum = tmp;
                    } else if (a[i] < secondNum.Item1)
                    {
                        var tmp = secondNum;
                        secondNum = new Tuple<int, int>(a[i], 1);
                        thirdNum = secondNum;
                    } else
                    {
                        thirdNum = new Tuple<int, int>(a[i], 1);
                    }

                }
            }

            List<Tuple<int, int>> list = new List<Tuple<int, int>>();
            list.Add(firstNum);
            list.Add(secondNum);
            list.Add(thirdNum);


            SortArray(a, list);
        }
    }
}
