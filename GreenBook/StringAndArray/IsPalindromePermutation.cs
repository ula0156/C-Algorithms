using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook.StringAndArray
{
    public static class IsPalindromePermutation
    {
        // TODO - what is the purpose of isOdd??? 
        private static bool findResult(Dictionary<char, int> letters, bool isOdd)
        { 
            var countOdds = 0;
            foreach (var key in letters.Keys)
            {
                if (letters[key] % 2 == 1)
                {
                    if (countOdds > 1 || !isOdd)
                    {
                        return false;
                    }

                    countOdds++;
                }
            } 

            return true;
        }

        public static bool _IsPalindromePermutation(string s)
        {
            var s1 = s.ToLower();
            Dictionary<char, int> letters = new Dictionary<char, int>();
            var count = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                if (!letters.ContainsKey(s1[i]) && s1[i] != ' ')
                {
                    letters.Add(s1[i], 1);
                    count++;
                } 
                else if (letters.ContainsKey(s1[i]))
                {
                    letters[s1[i]]++;
                    count++;
                }
            }

            var isOdd = false;
            if (count % 2 == 1)
            {
                isOdd = true;
            }

            return findResult(letters, isOdd);
        }
        
    }
}
