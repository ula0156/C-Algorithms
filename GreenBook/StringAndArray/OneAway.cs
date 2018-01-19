using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenBook.StringAndArray
{
    public static class OneAway
    {
        public static bool _OneAway(string s1, string s2)
        {
            var count = 0;
            var difference = s1.Length - s2.Length;
            var pos1 = 0;
            var pos2 = 0;

            if (difference > 1 || difference < -1)
            {
                return false;
            }

            while (pos1 < s1.Length && pos2 < s2.Length)
            {
                if (s1[pos1] != s2[pos2])
                {
                    if (difference < 0)
                    //delete
                    {
                        pos2++;
                    }
                    else if (difference > 0)
                    //insert
                    {
                        pos1++;
                    }
                    else
                    //change
                    {
                        pos1++;
                        pos2++;
                    }
                    count++;
                }

                if (count > 1)
                {
                    return false;
                }
                pos1++;
                pos2++;
            }

            count += Math.Max(s1.Length - pos1, s2.Length - pos2);

            return count <= 1;

        }
    }
}
