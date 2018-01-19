using System.Linq;

namespace Test.DynamicProgramming
{
    public class FindNumberOfWaysToFormSum
    {
        private static int CalculateNumOfWaysForDenomination(int index , int[] denimination)
        {
            if (index == 0)
            {
                return 1;
            }
            if (index == 1)
            {
                return 1 + (denimination[1] % denimination[0] == 0 ? 1 : 0);
            }
            return 1 + ((denimination[2] % denimination[0] == 0 ? 1 : 0) +
                (denimination[2] % denimination[1] == 0 ? 1 : 0) +
                (denimination[2] % (denimination[0] + denimination[1]) == 0 ? 2 : 0));
        }

        private static int NumberOfWays(int sum, int[] denominations, int[] arr)
        {
            if (sum < 0)
            {
                return 0;
            }
            if (sum == 0)
            {
                return 1;
            }

            if (arr[sum] >= 0)
            {
                return arr[sum];
            }

            var result = NumberOfWays(sum - denominations[0], denominations, arr) +
                NumberOfWays(sum - denominations[1], denominations, arr) +
                NumberOfWays(sum - denominations[2], denominations, arr);

            // sum serves as an index for the array
            arr[sum] = result;
            return result;
        }

        public static int NumberOfWaysToFormSum(int sum, int[] denominations)
        {
            int[] arr = Enumerable.Repeat(-1, sum + 1).ToArray();
            for (var i = 0; i < denominations.Length; i++) 
            {
                if (arr.Length < denominations[i])
                {
                    return 0;
                }
                    var waysToFormDenomonation = CalculateNumOfWaysForDenomination(i, denominations);
                arr[denominations[i]] = waysToFormDenomonation;
            }
            return NumberOfWays(sum, denominations, arr);
        }
        
        // pure dynamic programming. Bottom up approach
        public static int NumberOfWaysToFormSum2(int sum, int[] denominations)
        {
            int[] arr = new int[sum + 1];
            arr[0] = 1;
            
            for (var i = 0; i < denominations.Length; i++)
            {
                var waysToFormDenomonation = CalculateNumOfWaysForDenomination(i, denominations);
                arr[denominations[i]] = waysToFormDenomonation;
            }
            
            for (var i = denominations[2] + 1; i < arr.Length; i++)
            {
                if (sum < denominations[0])
                {
                    return 0;
                }
                if (sum >= denominations[0] && sum < denominations[1])
                {
                    return arr[i - denominations[0]];
                }
                if (sum >= denominations[1] && sum < denominations[2])
                {
                    return arr[i - denominations[0]] + arr[i - denominations[1]];
                }

                arr[i] = arr[i- denominations[0]] + arr[i - denominations[1]] + arr[i - denominations[2]];
            }

            return arr[sum];
        }

        public static int NumberOfWaysToFormSum3(int sum, int[] denominations)
        {
            int[] arr = new int[sum + 1];
            arr[0] = 1;

            foreach (var coint in denominations)
            {
                for (var hightAmount = coint; hightAmount < sum; hightAmount ++)
                {
                    var amountRemaining = hightAmount - coint;
                    arr[hightAmount] += arr[amountRemaining];
                }
            }

            return arr[sum];
        }
    }
}
