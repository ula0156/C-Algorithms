using System;

namespace Test.Strings
{
    public class StringOccurances
    {
        public static int GetOccurance(string s1, string s2)
        {
            if ((String.IsNullOrEmpty(s1) && String.IsNullOrEmpty(s2)) || String.IsNullOrEmpty(s1))
            {
                return 1;
            }

            var count = 0;
            var p1 = 0;
            var p2 = 0;
            var insideW = false;

            while(p1 < s1.Length)
            {
                if(p2 == s2.Length)
                {
                    if(insideW)
                    {
                        count++;
                        p2 = 0;
                        insideW = false;
                    } else
                    {
                        return (count > 0) ? count : -1;
                    }
                    
                } else if(s1[p1] == s2[p2])
                {
                    insideW = true;
                    p1++;
                    p2++;
                } else if(s1[p1] != s2[p2])
                {
                    insideW = false;
                    p2++;
                }
            }

            return (p2 != s2.Length) ? count + 1 : count;
        }
    }
}
