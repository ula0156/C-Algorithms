using System;
using System.Collections.Generic;

namespace Test.Stack
{
    public class EvaluateExpression
    {
        //Evaluate an expression given only single digits and only 2 operators * and +.

        public static int EvaluateGivenExpression(string s)
        {
            var stackDigits = new Stack<int>();
            var stackOperators = new Stack<char>();
            var number = 0;

            for (var i = 0; i < s.Length;)
            {
                if (Char.IsDigit(s[i]))
                {
                    stackDigits.Push(s[i] - '0');
                }
                else
                {
                    if (s[i] == '*')
                    {
                        stackDigits.Push((s[i + 1] - '0') * stackDigits.Pop());
                        i++;
                    }
                    else
                    {
                        stackOperators.Push(s[i]);
                    }
                }

                i++;
            }

            while (stackDigits.Count > 0)
            {
                number += stackDigits.Pop();
            }

            return number;
        }
    }
}
