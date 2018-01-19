using System;
using System.Collections.Generic;

namespace Test.DynamicProgramming
{
    public class KnapsackProblem
    {
        public static int GetMaxValue(int[] values, int[] weights, int target)
        {
            var v = new List<int>();
            v.Add(0);
            var w = new List<int>();
            w.Add(0);

            var max = 0;

            for (int i = 0; i < values.Length; i++)
            {
                var end = v.Count;
                for (int j = 0; j < end; j++)
                {
                    if (weights[i] == target || weights[i] + w[j] == target)
                    {
                        max = (weights[i] + w[j] == target) ? Math.Max(max, values[i] + v[j]) : Math.Max(max, values[i]);
                    }

                    else if(weights[i] + w[j] < target)
                    {
                        v.Add(values[i] + v[j]);
                        w.Add(weights[i] + w[j]);

                        var count = 2;

                        while ((count * weights[i]) <= target)
                        {
                            v.Add(values[i] * count);
                            w.Add(weights[i] * count);
                            if (weights[i] * count == target)
                            {
                                max = Math.Max(max, v[v.Count - 1]);
                                w.RemoveAt(w.Count - 1);
                                v.RemoveAt(v.Count - 1);
                            }
                            count++;
                        }
                    }
                }
            }

            return max;
        }

        public static int GetMaxValue2(int[] values, int[] weights, int target)
        {
            var capacityArr = new int[target + 1];
            
            for(var currentCapacity = 0; currentCapacity < capacityArr.Length; currentCapacity++)
            {
                var maxCurrentValue = 0;
                for (int i = 0; i < weights.Length; i++)
                {
                    if(weights[i] <= currentCapacity)
                    {
                        maxCurrentValue = Math.Max(maxCurrentValue, values[i] + capacityArr[currentCapacity - weights[i]]);
                    }
                }
               
                capacityArr[currentCapacity] = maxCurrentValue;
            }

            return capacityArr[capacityArr.Length - 1];
        }
    }
}
