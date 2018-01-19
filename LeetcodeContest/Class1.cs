using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeContest
{
    public class Node
    {
        public Tuple<int, int> Data;
        public Node Left;
        public Node Right;

        public Node(int st, int end)
        {
            Data = new Tuple<int, int>(st, end);
        }
    }

    public class MyCalendar
    {
        private Node _root;

        public MyCalendar()
        {

        }

        public bool Book(int start, int end)
        {
            if (_root == null)
            {
                _root = new Node(start, end);
                return true;
            }
            else
            {
                var cur = _root;
                var parent = _root;
                while (cur != null)
                {
                    if (start >= cur.Data.Item1 && cur.Data.Item2 > start)
                    {
                        return false;
                    }
                    else if (start < cur.Data.Item1 && cur.Data.Item1 < end)
                    {
                        return false;
                    }
                    else if (start > cur.Data.Item1)
                    {
                        parent = cur;
                        cur = cur.Right;
                    }
                    else if (start < cur.Data.Item1)
                    {
                        parent = cur;
                        cur = cur.Left;
                    }
                }
                if (parent.Data.Item1 > start)
                {
                    parent.Left = new Node(start, end);
                }
                else if (parent.Data.Item1 < start)
                {
                    parent.Right = new Node(start, end);
                }
            }
            return true;
        }
    }
}
