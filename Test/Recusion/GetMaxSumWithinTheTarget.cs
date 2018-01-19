using System;
using System.Collections.Generic;

namespace Test.Recusion
{
    public class GetMaxSumWithinTheTarget
    {
        public static int GetSum(Tuple<int, int>[] a, int pos, int target)
        {
            if (target == 0)
            {
                return 0;
            }
            if (pos < 0)
            {
                return 0;
            }
            if (pos >= 0 && (target - a[pos].Item2) < 0)
            {
                return GetSum(a, pos - 1, target);
            }

            return Math.Max(a[pos].Item1 + GetSum(a, pos - 1, target - a[pos].Item2), GetSum(a, pos - 1, target));
        }


        //DP solution
        public static int GetSumDP(Tuple<int, int>[] a, int target)
        {
            var max = 0;
            var values = new List<int>();
            values.Add(0);
            var weights = new List<int>();
            weights.Add(0);
            
            for (var i = 0; i < a.Length; i++)
            {
                var end = values.Count;
                for (var listPos = 0; listPos < end; listPos++)
                {
                    if((weights[listPos] + a[i].Item2) < target)
                    {
                        values.Add(values[listPos] + a[i].Item1);
                        weights.Add(weights[listPos] + a[i].Item2);
                    } else if ((weights[listPos] + a[i].Item2) == target)
                    {
                        max = Math.Max(values[listPos] + a[i].Item1, max);
                    }
                    
                }
            }

            return max;
        }
    }
}
