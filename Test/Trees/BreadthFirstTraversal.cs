using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Trees
{
    //Given a non-empty binary tree,
    //return the average value of the nodes on each level in the form of an array. 
    public class BreadthFirstTraversal
    {
        public static List<int> AverageOfLevels(Node n)
        {
            var sum = 0;
            var count = 0;
            var result = new List<int>();
        

            var q = new Queue<Tuple<Node, int>>();
            q.Enqueue(new Tuple<Node, int>(n, 1));

            while(q.Any())
            {
                var tmp = q.Dequeue();

                sum += tmp.Item1.Data;
                count++;

                if (tmp.Item1.Left != null)
                {
                    q.Enqueue(new Tuple<Node, int>(tmp.Item1.Left,tmp.Item2 + 1));
                }
                if (tmp.Item1.Right != null)
                {
                    q.Enqueue(new Tuple<Node, int>(tmp.Item1.Right, tmp.Item2 + 1));
                }

                if (!q.Any())
                {
                    count++;
                    result.Add(sum / count);
                    count = 0;
                }
                else
                {
                    if (tmp.Item2 != q.Peek().Item2)
                    {
                        result.Add(sum / count);
                        count = 0;
                        sum = 0;
                    }
                }
            }

            return result;
        }
    }
}
