using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TryToFindMin
    {
        public static Tuple<bool, int> TryFindMin(Node n)
        {
            if (n == null)
            {
                return new Tuple<bool, int>(false, int.MaxValue);
            }
            int min = n.Data;
            var TryFindLeftMin = TryFindMin(n.Left);
            if (TryFindLeftMin.Item1 == true)
            {
                min = Math.Min(min, TryFindLeftMin.Item2);
            }

            var TryFindRightMin = TryFindMin(n.Right);
            if (TryFindRightMin.Item1 == true)
            {
                min = Math.Min(min, TryFindRightMin.Item2);
            }

            return new Tuple<bool, int>(true, min);
        }
    }
}
