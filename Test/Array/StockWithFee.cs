using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public class StockWithFee
    {
        public static int MaxProfit(int[] a, int fee)
        {
            var bought = a[0];
            var profit = 0;
            for (var i = 1; i < a.Length; i++)
            {
                if ((a[i] - fee - bought) > 0)
                {
                    var j = i;
                    var toGet = a[i];
                    while (j > a.Length && a[j] >= a[i])
                    {
                        toGet = a[j];
                        j++;
                    }
                    profit += toGet - fee - bought;
                    i = j;
                    bought = int.MaxValue;
                }
                else if (bought > a[i])
                {
                    bought = a[i];
                }
            }
            return profit;
        }
    }
}
