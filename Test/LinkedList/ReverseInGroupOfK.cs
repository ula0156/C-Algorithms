using Test.List;

namespace Test.LinkedList
{
    public static class ReverseInGroupOfK
    {
        private static NodeLinkedList Reverse(NodeLinkedList head, out NodeLinkedList nextHead, int k)
        {
            var cur = head;
            NodeLinkedList pr = null;
            var next = cur;

            while(cur != null && k > 0)
            {
                next = cur.Next;
                cur.Next = pr;
                pr = cur;
                cur = next;
                k--;
            }

            nextHead = cur;
            return pr;
        }


        public static NodeLinkedList ReverseByGroup(NodeLinkedList head, int k)
        {
            NodeLinkedList globalHead = null;
            var cur = head;

            /*
             * It's tail of previous group of K
             * Memorize it in order to connect it to the Head of the next reversed group of K
             */

            var prTail = cur;

            while(cur != null)
            {
                var tail = cur;
                NodeLinkedList nextHead = null;
                var reversedHead = Reverse(cur, out nextHead, k);

                if(globalHead == null)
                {
                    globalHead = reversedHead;
                }else
                {
                    prTail.Next = reversedHead;
                }

                prTail = tail;
                cur = nextHead;
            }

            return globalHead;
        }
    }
}
