using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights
{
    public class StringPermutations
    {
        public static string[] Permutations(string s)
        {
            char[] array = s.ToArray();
            Array.Sort(array);
            s = String.Join("", array);
            List<int> numList = new List<int>();
            Dictionary<int, char> letters = new Dictionary<int, char>();
            for (int i = 0; i < s.Length; i++)
            {
                letters.Add(i, s[i]);
                numList.Add(-1);
            }

            int[] numArr = numList.ToArray();

            int pos = 0;
            int k = numArr.Length - 1;
            List<string> result = new List<string>();
            string last = "";
            while (pos >= 0) {
                if (pos == numArr.Length) {
                    string combination = "";
                    for (var n = 0; n < numArr.Length; n++) {
                        char character = letters[numArr[n]];
                        combination += character;
                    }

                    int comparison = string.Compare(combination, last);
                    if (comparison == 1) {
                        result.Add(combination);
                        last = combination;
                    }

                    pos--;
                }

                while (pos < numArr.Length && pos >= 0) {
                    if (numArr[pos] < k) {
                        numArr[pos]++;
                    } else {
                        numArr[pos] = -1;
                        pos--;
                        break;
                    }

                    bool isValid = true;
                    for (int j = 0; j < pos; j++) {
                        if (numArr[pos] == numArr[j]) {
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid) {
                        pos++;
                    }
                }
            }

            return result.ToArray();

        }
    }
}