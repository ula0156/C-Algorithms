using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Strings
{
    public class ReverseWord
    {
        public static string ReverseString(string s)
        {
            char[] arr = new char[s.Length];
            var i = 0;
            var j = s.Length - 1;
            while (i <= j)
            {
                arr[j] = s[i];
                arr[i] = s[j];
                i++;
                j--;
            }

            return new String(arr);
        }
    }
}
