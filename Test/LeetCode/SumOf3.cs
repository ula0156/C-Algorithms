using System.Collections.Generic;

namespace Test.LeetCode
{
    public class SumOf3
    { 
        private static IList<int> AddToList(int[] nums, int l, int m, int r)
        {
            var list = new List<int>();
            list.Add(nums[l]);
            list.Add(nums[m]);
            list.Add(nums[r]);
            return list;
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            if (nums.Length < 3)
            {
                return null;
            }

            System.Array.Sort(nums);
            HashSet<IList<int>> added = new HashSet<IList<int>>();

            IList<IList<int>> result = new List<IList<int>>();
            var l = 0;
            var m = l + 1;
            var r = nums.Length - 1;

            while (l < m && r > m)
            {
                var sum = nums[l] + nums[m] + nums[r];

                if (sum > 0)
                    r--;

                else if (sum == 0)
                {
                    var list = AddToList(nums, l, m, r);
                    if (!added.Contains(list))
                    {
                        result.Add(list);
                        added.Add(list);
                    }

                    l += 1;
                    m = l + 1;
                }

                else
                {
                    while (m < r)
                    {
                        if (nums[l] + nums[m] + nums[r] == 0)
                        {
                            var list = AddToList(nums, l, m, r);
                            if (!added.Contains(list))
                            {
                                result.Add(list);
                                added.Add(list);
                            }
                            break;
                        }
                        else
                            m++;
                    }
                    l += 1;
                    m = l + 1;
                }
            }
            return result;
        }
    }
}
