using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public class NotAppears
    {
        public static List<int> FindDisappearedNumbers(int[] nums)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                var index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                {
                    nums[index] *= -1;
                }
            }

            var result = new List<int>();
            for (var j = 0; j < nums.Length; j++)
            {
                if (nums[j] > 0)
                {
                    result.Add(j + 1);
                }
            }

            return result;
        }
    }
}
