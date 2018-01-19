using System;
using System.Collections.Generic;
namespace Test.Heap
{
    public class CompareTuples : IComparer<Tuple<int, int>>
    {
        public int Compare(Tuple<int, int> x, Tuple<int, int> y)
        {
            if (x.Item2 != y.Item2)
            {
                return x.Item2 - y.Item2;
            } else
            {
                return x.Item1 - y.Item1;
            }
        }
    }


    public class GetTotalTimeToExecute
    {
        private static int CalculateTime(int[] arr, int k)
        {
            var time = 0;

            var tasks = new Dictionary<int, int>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (!tasks.ContainsKey(arr[i]))
                {
                    tasks.Add(arr[i], i + k + 1);
                    time++;
                }
                else
                {
                    if (tasks[arr[i]] > time)
                    {
                        time += tasks[arr[i]] - time + 1;
                    }
                    time++;
                    tasks[arr[i]] = time + k;
                }
            }

            return time;
        }


        public static int GetTime(int[] arr, int k)
        {
            var tasks = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                if (!tasks.ContainsKey(item))
                {
                    tasks.Add(item, 1);
                }
                else
                {
                    tasks[item]++;
                }
            }

            var comparer = new CompareTuples();

            // adding values to sortedSet, sort is based on value
            var maxHeap = new SortedSet<Tuple<int, int>>(comparer);

            foreach (var item in tasks)
            {
                var element = new Tuple<int, int>(item.Key, item.Value);
                maxHeap.Add(element);
            }


            var q = new Queue<Tuple<Tuple<int, int>, int>>();
            var index = 0;

            while (maxHeap.Count > 0)
            {
                if (q.Count > 0 && index - q.Peek().Item2 > k)
                {
                    maxHeap.Add(q.Dequeue().Item1);
                }

                var task = maxHeap.Max;
                maxHeap.Remove(task);
                arr[index] = task.Item1;

                if (task.Item2 > 1)
                {
                    var leftTask = new Tuple<int, int>(task.Item1, task.Item2 - 1);
                    q.Enqueue(new Tuple<Tuple<int, int>, int>(leftTask, index));
                }

                index++;
            }

            return CalculateTime(arr, k);
        }
    }
}
