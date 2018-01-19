using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.MockInterviews
{
    public class RemoveComments
    {
        public static void TryToRemoveComments(string s)
        {
            if (s.Length < 1)
            {
                throw new ArgumentOutOfRangeException();
            }

            var stInd = -1;
            var charArr = s.ToList();
            var count = 0;


            for (var i = 0; i < charArr.Count; i++)
            {
                if (s[i] == '/' && i + 1 < charArr.Count && s[i + 1] == '*')
                {
                    stInd = i;
                    count++;
                }

                else if (stInd != -1 && s[i] == '*' && i + 1 < charArr.Count && s[i + 1] == '/')
                {
                    count += 2;
                    charArr.RemoveRange(stInd, count);
                    i = 0;
                    stInd = -1;
                }
            }

            for (var j = 0; j < charArr.Count; j++)
            {
                if (s[j] == '/' && j + 1 < charArr.Count && s[j + 1] == '/')
                {
                    // Remove line from j until \n
                }
            }
        }
    }
}
