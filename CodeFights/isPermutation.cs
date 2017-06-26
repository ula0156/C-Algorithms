using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    class isPermutation
    {
        public static bool isPermutationOfThe2ndString(string s1, string s2)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (char element in s1)
            {
                if (!letters.ContainsKey(element))
                {
                    letters.Add(element, 1);
                } else
                {
                    letters[element]++;
                }
            }
            foreach (char elementS2 in s2)
            {
                if (letters.ContainsKey(elementS2) && letters[elementS2] > 0)
                {
                    letters[elementS2]--;
                } else {
                    return false;
                }
            }
            return true;
        }
    }
}
