using System.Collections.Generic;

namespace Test.LeetCode
{
    public class PartitionArr
    {
        public static bool CanPartition(int[] nums)
        {
            var sum = 0;
            var _hs = new HashSet<int>();
            foreach (var n in nums)
            {
                sum += n;
            }

            if (sum % 2 == 1)
            {
                return false;
            }

            var list = new List<int>();
            list.Add(0);

            foreach (var num in nums)
            {
                var end = list.Count;
                for (var i = 0; i < end; i++)
                {
                    if (!_hs.Contains(num + list[i]))
                    {
                        _hs.Add(num + list[i]);
                        list.Add(num + list[i]);
                    }
                }
            }

            return (_hs.Contains(sum / 2));
        }
    }
}