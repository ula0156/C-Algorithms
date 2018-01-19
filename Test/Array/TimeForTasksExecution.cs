using System.Collections.Generic;

namespace Test.Array
{
    public class TimeForTasksExecution
    {
        public static int GetTotalTime(int[] arr, int k)
        {
            var tasks = new Dictionary<int, int>();
            var coolDown = 0;

            for (var i = 0; i < arr.Length; i++)
            {
                if (!tasks.ContainsKey(arr[i]))
                {
                    tasks.Add(arr[i], i + coolDown);
                }
                else
                {
                    var distance = i + coolDown - tasks[arr[i]];
                    if (k >= distance)
                    {
                        coolDown += k - (distance - 1);
                    }

                    tasks[arr[i]] = i + coolDown;
                }
            }

            return arr.Length + coolDown;
        }
    }
}
