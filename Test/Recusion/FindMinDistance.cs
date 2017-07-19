using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class FindMinDistance
    {
        
        public static int GetMinDistance(List<Tuple<int, int, int>> distance, int n) 
        {
            Tuple<int, int> min = findMinDistance(distance, n);
            return Math.Min(min.Item1, min.Item2);
        }
        
        private static Tuple<int, int> findMinDistance(List<Tuple<int,int,int>> distance, int n)
        {
            int x;
            int y;
            if (n == distance.Count)
            {
                x = 0;
                y = 0;
                return new Tuple<int, int>(x, y);
            }
            var previous = findMinDistance(distance, n + 1);
            x = Math.Min(previous.Item1 + distance[n].Item1, previous.Item2 + distance[n].Item2 + distance[n].Item1);
            y = Math.Min(previous.Item2 + distance[n].Item3, previous.Item1 + distance[n].Item2 + distance[n].Item3);

            return new Tuple<int, int>(x, y);
        }
        
    }
}
