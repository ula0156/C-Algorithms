using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class FindDup
    {
        // Given the arr of num from 1 to n-1 and exactly 1 dup, fund this number.
        public static int FindDupNum(int[] a)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int duplicate = 0;
            foreach (int number in a) 
            {
                if (numbers.ContainsKey(number))
                {
                    // why i cant return here and don't return anything at the end of the program???/
                    duplicate = number;
                    break;
                } else
                {
                    numbers.Add(number, 1);
                }
            }

            return duplicate;
        }

        // How to implement algorithm you explain yesterday???

    }
}
