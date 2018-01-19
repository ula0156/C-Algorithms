using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook.StringAndArray
{
    public static class ReplaceEmptySpace
    {
        private static void Insert(StringBuilder result, int i)
        {
            var toInsert = "%20";
            for (int g = toInsert.Length - 1; g >= 0 ; g--)
            {
                result[i] = toInsert[g];
                i--;
            }
        }

        public static string ReplaceSpace(string s)
        {
            StringBuilder result = new StringBuilder();
            for (int k = 0; k < s.Length; k++)
            {
                result.Append(s[k]);
            }

            bool insideTheWord = false;
            var i = result.Length - 1;

            for (int j = i - 1; j >= 0; j--)
            {
                if (result[j] == ' ' && insideTheWord)
                {
                    insideTheWord = false;
                    Insert(result, i);
                    i -= 3;
                }
                else if (result[j] != ' ')
                {
                    insideTheWord = true;
                    var tmp = result[i];
                    result[i] = s[j];
                    result[j] = tmp;
                    i--;
                }
            }

            return result.ToString();
        }
    }
}
