using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Stack
{
    public class BiggestNeighbor
    {
        public static int[] GetBiggestNeighbor(int[] a)
        {
            var leftNeighbor = new int[a.Length];
            leftNeighbor[0] = -1;
            var rightNeighbor = new int[a.Length];
            rightNeighbor[a.Length - 1] = -1;

            var stack = new Stack<Tuple<int, int>>();

            stack.Push(new Tuple<int, int>(a[0], 0));

            // calculating left neighbore
            for (var i = 1; i < a.Length; i++)
            {
                if (a[i] < a[i - 1])
                {
                    leftNeighbor[i] = i - 1;
                    stack.Push(new Tuple<int, int>(a[i], i));
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        stack.Pop();
                        if (stack.Count > 0 && stack.Peek().Item1 > a[i])
                        {
                            leftNeighbor[i] = stack.Peek().Item2;
                            break;
                        }
                    }
                    if (stack.Count == 0)
                    {
                        leftNeighbor[i] = -1;
                    }

                    stack.Push(new Tuple<int, int>(a[i], i));
                }
            }

            stack.Clear();

            // calculating right neighbore
            for (var j = a.Length - 2; j >= 0; j--)
            {
                if (a[j] < a[j + 1])
                {
                    rightNeighbor[j] = j + 1;
                    stack.Push(new Tuple<int, int>(a[j], j));
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        stack.Pop();
                        if (stack.Count > 0 && stack.Peek().Item1 > a[j])
                        {
                            rightNeighbor[j] = stack.Peek().Item2;
                            break;
                        }
                    }
                    if (stack.Count == 0)
                    {
                        rightNeighbor[j] = -1;
                    }

                    stack.Push(new Tuple<int, int>(a[j], j));
                }
            }

            
            var index = 0;

            var result = new int[a.Length];
            while (index < a.Length)
            {
                if (rightNeighbor[index] == -1)
                {
                    result[index] = leftNeighbor[index];
                }
                else if (leftNeighbor[index] == -1)
                {
                    result[index] = rightNeighbor[index];
                }
                else
                {
                    result[index] = a[rightNeighbor[index]] > a[leftNeighbor[index]] ? rightNeighbor[index] : leftNeighbor[index];
                }

                index++;
            }

            return result;
        }
    }
}
