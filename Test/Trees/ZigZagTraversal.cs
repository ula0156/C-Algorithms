using System.Collections.Generic;

namespace Test.Trees
{
    public class ZigZagTraversal
    {
        public List<List<int>> ZigzagLevelOrder(Node n)
            {
                var result = new List<List<int>>();
                var q = new Queue<Node>();
                q.Enqueue(n);
                bool isRight = false;

                while (q.Count > 0)
                {
                    var count = q.Count;
                    var list = new List<int>();
                    while (count > 0)
                    {
                        var tmp = q.Dequeue();
                        list.Add(tmp.Data);
                        if (tmp.Left != null)
                        {
                            q.Enqueue(tmp.Left);
                        }
                        if (tmp.Right != null)
                        {
                            q.Enqueue(tmp.Right);
                        }
                        count--;
                    }
                    if (isRight)
                    {
                        var stInd = 0;
                        var endInd = list.Count - 1;
                        while (stInd <= endInd)
                        {
                            var tmp = list[stInd];
                            list[stInd] = list[endInd];
                            list[endInd] = tmp;
                        }
                        isRight = false;
                    }
                    result.Add(list);
                }
                return result;
            }
    }
}
