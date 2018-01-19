using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook.StringAndArray
{
    public static class StringCompression
    {
        public static string CompressString(string s)
        {
            if (s.Length < 2)
            {
                return s;
            }

            s.ToLower();
            StringBuilder result = new StringBuilder();

            var count = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i-1])
                {
                    count++;
                }
                else
                {
                    result.Append(s[i - 1]);
                    result.Append(count);
                    count = 1;
                }
            }

            result.Append(s[s.Length - 1]);
            result.Append(count);

            if (result.Length >= s.Length)
            {
                return s;
            }

            return result.ToString();
        }
    }
}
