using System;
using System.Collections.Generic;

namespace Test.LeetCode
{
    public class Atoi
    {
        private static int EmptyStack(Stack<int> stack, char sign)
        {
            var number = 0;

            var power = stack.Count - 1;
            while (stack.Count > 0)
            {
                try
                {
                    var p = power - (stack.Count - 1);
                    var x = checked(number += stack.Pop() * ((int)Math.Pow(10, p)));
                }
                catch
                {
                   return (sign == '-') ? int.MinValue: int.MaxValue;
                }
            }

            return (sign == '-') ? number * -1 : number;
        }

        public static int MyAtoi(string s)
        {
            var stack = new Stack<int>();
            char sign = '?';

            var i = 0;

            //remove all leading spaces
            while (i < s.Length)
            {
                if (s[i] == ' ')
                    i++;
                else break;
            }


            for (; i < s.Length; i++)
            {
                if (s[i] == '-' || s[i] == '+')
                {
                    if (stack.Count > 0 || sign != '?')
                    {
                        return EmptyStack(stack, sign);
                    }
                    else
                    {
                        sign = s[i];
                    }
                }

                else if (!Char.IsDigit(s[i]))
                    return EmptyStack(stack, sign);
                

                else if (s[i] == '0' && stack.Count > 0)
                    stack.Push(s[i] - '0');
                
                else if (Char.IsDigit(s[i]))
                    stack.Push(s[i] - '0');
            }

            return EmptyStack(stack, sign);
        }
    }
}
