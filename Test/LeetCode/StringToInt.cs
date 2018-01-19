using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LeetCode
{
    public class StringToInt
    {
        public int MyAtoi(string str)
        {
            var sign = '+';
            var list = new List<int>();
            var indexOfFisrDigit = -1;
            for (var i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                {
                    if (indexOfFisrDigit == -1)
                    {
                        indexOfFisrDigit = i;
                    }
                    list.Add(str[i] + '0');
                }
            }

            if (indexOfFisrDigit - 1 > 0 && str[indexOfFisrDigit - 1] == '-')
                sign = '-';

            var max_value = 2147483647;
            var min_value = int.MinValue;
            var valueToCheck = max_value;
            int num = 0;

            if (list.Count > 0)
            {
                num = (sign == '-') ? list[0] * -1 : list[0];
                valueToCheck = (sign == '-') ? min_value : max_value;

                for (var j = 1; j < list.Count; j++)
                {
                    try
                    {
                        // The following line raises an exception because it is checked.
                        num = checked(num + list[j] * (int)Math.Pow(10, list.Count - j - 1));
                    }
                    catch (System.OverflowException e)
                    {
                        return valueToCheck;
                    }
                }
                return num;
            }
            return 0;
        }
    }
}
