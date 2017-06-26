using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class StringSorting
    {
        public static string sortByString(string s, string t)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (char element in s)
            {
                if (!letters.ContainsKey(element)) { 
                    letters.Add(element, 1);
                }
                else
                {
                    letters[element]++;
                }
            }

            StringBuilder result = new StringBuilder();

            foreach (char elementT in t)
            {
                if (letters.ContainsKey(elementT))
                {
                    result.Append(elementT, letters[elementT]);
                }
            }

            return result.ToString();
        }

    }
}
