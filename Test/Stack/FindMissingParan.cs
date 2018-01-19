
using System.Collections.Generic;

namespace Test.Stack
{
    public class FindMissingParan
    {
        //Find missing parenthesis in a given expression – 2 * ( 3 + 5(sasdfasdfasd)

        public static bool FindMissingParanthesis(string s)
        {
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                if (item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ')')
                {
                    stack.Pop();
                }
            }

            return stack.Count > 0 ? true : false;
        }


        //Find position of first missing parenthesis in a given expression – ( 2 * (2 + 3) + 5(sasdfasdfasd)

        public static int FindPositionOfMissingParanthesis(string s)
        {
            var stack = new Stack<int>();
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else if (s[i] == ')')
                {
                    stack.Pop();
                }
            }
            if (stack.Count > 0)
            {
                while (stack.Count > 1)
                {
                    stack.Pop();
                }

                return stack.Peek();
            }
            // no missing paren
            return -1;
        }


        //Find position of all missing parenthesis
        
        public static List<int> FindPositionOfFirstMissingParanthesis(string s)
        {
            var stack = new Stack<int>();
            var listOfMissingParen = new List<int>();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }

                else if (s[i] == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else
                    {
                        listOfMissingParen.Add(s[i]);
                    }
                }
            }

            while (stack.Count >= 0)
            {
                listOfMissingParen.Add(stack.Pop());
            }

            return listOfMissingParen;
        }
    }
}
