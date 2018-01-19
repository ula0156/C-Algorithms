using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook.StringAndArray
{
    public static class IsPermutationOfS1
    {
        // TODO - why public methods start with _????
        public static bool _IsPermutationOfS1(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            Dictionary<char, int> letters = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                if (!letters.ContainsKey(s1[i]))
                {
                    letters.Add(s1[i], 1);
                }
                else
                {
                    letters[s1[i]]++;
                }
            }

            for (int j = 0; j < s2.Length; j++)
            {
                if (!letters.ContainsKey(s2[j]) || letters[s2[j]] == 0) 
                {
                    return false;
                }
                letters[s2[j]]--;
            }

            return true;
        }
    }
}
