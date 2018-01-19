using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.List
{
    public static class IsLinkedListPalindrome
    {
        public static bool _IsLinkedListPalindrome(NodeLinkedList head)
        {
            //1. count number of nodes in the LL
            //2. calculating # of nodes for left and right hand side.
            //if length%2 != 0 -> additional node stayed on the left
            //3. iterating through the lists campering datas.
            NodeLinkedList current = head;
            int count = 0;
            while (current != null)
            {
                current = current.Next;
                count++;
            }
            current = head;
            NodeLinkedList tailOfReversed = null;
            int lastElementOfTheOriginalList = (count / 2) + (count % 2);
            int countForFirstHalf = 1;
            while (current != null)
            {
                if (countForFirstHalf == lastElementOfTheOriginalList)
                {
                    tailOfReversed = current.Next;
                    current.Next = null;
                    break;
                }
                countForFirstHalf++;
                current = current.Next;
            }
            NodeLinkedList currentReversed = tailOfReversed;
            NodeLinkedList previous = null;
            NodeLinkedList next = null;
            int countForSecondHalf = count - countForFirstHalf;
            while (currentReversed != null)
            {
                next = currentReversed.Next;
                currentReversed.Next = previous;
                previous = currentReversed;
                currentReversed = next;
            }
            NodeLinkedList headOfReversed = previous;

            currentReversed = headOfReversed;
            current = head;

            if (countForFirstHalf == countForSecondHalf)
            {
                while (current != null)
                {
                    if (current.Data != currentReversed.Data)
                    {
                        return false;
                    }
                    current = current.Next;
                    currentReversed = currentReversed.Next;
                }
            }
            else if (countForFirstHalf > countForSecondHalf)
            {
                while (currentReversed != null)
                {
                    if (current.Data != currentReversed.Data)
                    {
                        return false;
                    }
                    current = current.Next;
                    currentReversed = currentReversed.Next;
                }
            }

            return true;
        }

        public static bool _IsLinkedListPalindrome2(NodeLinkedList head)
        {
            // solution with using stack!
            // to calculate a length -> use two pointers
            // if LL length is odd -> right(smaller) half will to the stack
            var pSlow = head;
            var pFast = head;
            Stack<NodeLinkedList> stack = new Stack<NodeLinkedList>();
            while (pFast.Next != null)
            {
                pFast = pFast.Next.Next;
                if (pFast == null)
                { 
                    break;
                }

                pSlow = pSlow.Next;
            }

            // pSlow is the last element of the first half
            // starting to push pSlow.next to the stack
            pSlow = pSlow.Next;
            while (pSlow != null)
            {
                stack.Push(pSlow);
                pSlow = pSlow.Next;
            }

            pSlow = head;
            while (stack.Count > 0)
            {
                if (pSlow.Data != stack.Pop().Data)
                {
                    return false;
                }
                else
                {
                    pSlow = pSlow.Next;
                }
            }

            return true;
        }
    }
}
