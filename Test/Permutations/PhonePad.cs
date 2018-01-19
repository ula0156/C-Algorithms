using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Recusion
{
    public static class PhonePad
    {
        public static List<string> AllPossiblePermutations()
        {
            char[] num = new char[] { '1', '2', '3' };
            Dictionary<char, string> phone = new Dictionary<char, string>();
            phone.Add('1', "abc");
            phone.Add('2', "def");
            phone.Add('3', "ghtr");
            List<char> charComb = new List<char>();
            List<string> result = new List<string>();
            getPermutations(num, charComb, result, 0, phone);
            return result;
        }
        
        private static void getPermutations(char[] num, List<char> charComb, List<string> result, int pos, Dictionary<char, string> phone)
        {
            if (pos == num.Length)
            {
                result.Add(string.Join("", charComb.ToArray()));
                return;
            }
            var letterComb = phone[num[pos]];
            for (var i = 0; i < letterComb.Length; i++)
            {
                charComb.Add(letterComb[i]);
                getPermutations(num, charComb, result, pos + 1, phone);
                charComb.RemoveAt(pos);
            }
        }
    }
}
