using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.List
{
    public static class SumLinkedListsValues
    {
        public static NodeLinkedList GetNewLinkedList(NodeLinkedList a, NodeLinkedList b)
        {
            //reverse list a
            NodeLinkedList ReversedHeadA = ReverseLinkedList(a);

            //reverse list b
            NodeLinkedList ReversedHeadB = ReverseLinkedList(b);

            //initializing result list with sum of numbers but in reverse order yet;
            //also can use stack for it
            NodeLinkedList resultHead = null;
            NodeLinkedList resultCurrent = null;

            int remainder = 0;
            while (ReversedHeadA != null || ReversedHeadB != null)
            {
                int sumNodeValue;
                if (ReversedHeadA == null)
                {
                    //check if node in list a == null -> calculating sum for result list
                    sumNodeValue = GetSumOfNumbers(ReversedHeadB.Data + remainder, 0, out remainder);
                    resultCurrent.Next = new NodeLinkedList(sumNodeValue);
                    resultCurrent = resultCurrent.Next;
                    ReversedHeadB = ReversedHeadB.Next;
                }
                else if (ReversedHeadB == null)
                {
                    //check if node in list b == null -> calculating sum for result list
                    sumNodeValue = GetSumOfNumbers(ReversedHeadA.Data + remainder, 0, out remainder);
                    resultCurrent.Next = new NodeLinkedList(sumNodeValue);
                    resultCurrent = resultCurrent.Next;
                    ReversedHeadA = ReversedHeadA.Next;
                }
                else {
                    // head is not set yet
                    if (resultHead == null)
                    {
                        sumNodeValue = GetSumOfNumbers(ReversedHeadA.Data, ReversedHeadB.Data, out remainder);
                        resultHead = new NodeLinkedList(sumNodeValue);
                        resultCurrent = resultHead;
                    }
                    else {
                        sumNodeValue = GetSumOfNumbers(ReversedHeadA.Data + remainder, ReversedHeadB.Data, out remainder);
                        resultCurrent.Next = new NodeLinkedList(sumNodeValue);
                        resultCurrent = resultCurrent.Next;
                    }

                    ReversedHeadA = ReversedHeadA.Next;
                    ReversedHeadB = ReversedHeadB.Next;
                }
            }
            
            if (remainder > 0)
            {
                resultCurrent.Next = new NodeLinkedList(remainder);
            }

            // reversing result list
            return ReverseLinkedList(resultHead);
        }
        private static NodeLinkedList ReverseLinkedList(NodeLinkedList head)
        {
            NodeLinkedList previous = null;
            NodeLinkedList next = null;
            NodeLinkedList current = head;
            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            return previous;
        }

        private static int GetSumOfNumbers(int x, int y, out int remainder)
        {
            int sum = x + y;
            if (sum / 10000 < 1)
            {
                remainder = 0;
                return sum;
            }
            remainder = sum / 10000;
            return (sum - (remainder * 10000));
        }

    }
}

