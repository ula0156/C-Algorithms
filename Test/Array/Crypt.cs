using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public static class Crypt
    {
        private static int findDigit(char[][] solution, char letter)
        {
            foreach (var pair in solution)
            {
                if (pair[0] == letter)
                {
                    return pair[1] - '0';
                }
            }
            return -1;
        }


        public static bool isCryptSolution(string[] crypt, char[][] solution)
        {
            int[] result = new int[3];
            var pos = 0;
            foreach (var word in crypt)
            {
                int number = 0;
                var isFirstDigit = true;

                for (var i = 0; i < word.Length; i++)
                {

                    // checking for the fist digit if it's 0
                    int digit = findDigit(solution, word[i]);
                    if (isFirstDigit)
                    {
                        if (digit == 0)
                        {
                            return false;
                        }
                        isFirstDigit = false;
                    }

                    number += digit * (int)Math.Pow(10, word.Length - 1 - i);
                }
                result[pos] = number;
                pos++;
            }

            return result[0] + result[1] == result[2];
        }

    }
}
