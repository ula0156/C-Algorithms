using System.Collections.Generic;

namespace Test.Stack
{
    public class ReverseStack
    {
        //Reverse a stack and put the reversed value back in the same stack.
        //You can use only one other stack and a temp variable.

        public static void ReverseAStack1(Stack<int> stack)
        {
            //  Used 2 additional stacks

            var reversedStack = new Stack<int>();
            var reversedStack2 = new Stack<int>();

            foreach (var item in stack)
            {
                reversedStack.Push(stack.Pop());
            }

            foreach (var item in stack)
            {
                reversedStack2.Push(reversedStack.Pop());
            }

            foreach (var item in stack)
            {
                stack.Push(reversedStack2.Pop());
            }
        }

        public static void ReverseAStack2(Stack<int> stack)
        {
            //  Used 1 additional stacks

            var reversedStack = new Stack<int>();
            var count = stack.Count;

            while(count > 0)
            {
                var tmp = stack.Pop();
                count--;

                while (count > 0)
                {
                    reversedStack.Push(stack.Pop());
                    count--;
                }
                stack.Push(tmp);
                count = reversedStack.Count;

                while (reversedStack.Count > 0)
                {
                    stack.Push(reversedStack.Pop());
                }
            }
        }
    }
}
