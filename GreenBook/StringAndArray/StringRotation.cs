using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook.StringAndArray
{
    public static class StringRotation
    {

        private static bool isSubstring(string s1, string result, int pos1, int pos2)
        {
            while (pos1 < s1.Length)
            {
                if (s1[pos1] != result[pos2])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool _StringRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            var result = s2 + s2;
            var pos1 = 0;
            var pos2 = 0;
            var isRotatedString = false;

            while (pos1 < s1.Length && pos2 < result.Length)
            {
                if (s1[pos1] != result[pos2])
                {
                    pos2++;
                }
                else
                { 
                    isRotatedString = isSubstring(s1, result, pos1, pos2);
                }
            }

            return isRotatedString;
        }
    }
}
