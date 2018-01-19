using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook.StringAndArray
{
    public static class AreAllUnique
    {
        public static bool AreUnique(string s)
        {
            HashSet<char> letters = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!letters.Contains(s[i]))
                {
                    letters.Add(s[i]);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool AreUnique2(string s)
        {
            // TODO - technically this is not without additional memory. Would be in c++\
            // Use 2 fors for c#
            char[] charArr = s.ToArray();
            Array.Sort(charArr);
            for (int i = 0; i < charArr.Length - 1; i++)
            {
                if (charArr[i] == charArr[i+1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
