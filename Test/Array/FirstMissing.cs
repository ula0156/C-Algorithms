using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public class FirstMissing
    {
        public static int FirstMissingPositive(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var x = 0;
                var idx = i;
                while (idx < nums.Length && idx >= 0 && nums[idx] != idx + 1)
                {
                    var tmp = nums[idx];
                    nums[idx] = x;
                    x = tmp;
                    idx = x - 1;
                }
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0)
                {
                    return i + 1;
                }
            }

            return nums.Length + 1;
        }
    }
}
