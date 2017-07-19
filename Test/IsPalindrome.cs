using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class IsPalindrome
    {
        public static bool IsStringPalindrome(string s)
        {
            int stopCondition = s.Length / 2;
            for (int i = 0, j = s.Length - 1; i <= stopCondition; i++, j--)
            {
                if (s[i] != s[j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
