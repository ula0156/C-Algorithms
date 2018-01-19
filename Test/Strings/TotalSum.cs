using System;

namespace Test.Strings
{
    public class TotalSum
    {
/*        private enum States
        {
            ReadingName,
            StartReadingPrice,
            ReadingPrice,
        }

        public static int GetTotalSumEnum(strings)
        {

        } */

        public static int GetTotalSum(string s)
        {
            var isReadingName = true;
            var isReadingPrice = false;
            var isReadingQuantity = false;
            var totalPrice = 0;
            int price = 0;
            var quantity = 0;
            int count = 0;

            for(var i = 0; i < s.Length; i++)
            {
                if (isReadingName)
                {
                    price = 0;
                    quantity = 0;
                    if (s[i] != ' ')
                    {
                        count++;
                    }
                    else if (count > 0 && s[i] == ' ')
                    {
                        isReadingName = false;
                        isReadingPrice = true;
                        count = 0;
                    }
                }
                else if (isReadingPrice)
                {
                    if (Char.IsDigit(s[i]))
                    {
                        price = price * 10 + s[i] - '0';
                        count++;
                    }
                    else if (count == 0 && s[i] != ' ')
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else if (count > 0 && s[i] == ' ')
                    {
                        isReadingQuantity = true;
                        isReadingPrice = false;
                        count = 0;
                    } else if (s[i] == ',') {
                        totalPrice += price;
                        isReadingName = true;
                        isReadingPrice = false;
                        count = 0;
                    }
                }
                else if (isReadingQuantity)
                {
                    if (Char.IsDigit(s[i]))
                    {
                        quantity = quantity * 10 + s[i] - '0';
                        count++;
                    }
                    else if (count > 0 && s[i] != ',' && s[i] != ' ')
                    {
                        throw new IndexOutOfRangeException();
                    }
                    else if (s[i] == ',')
                    {
                        totalPrice = count > 0 ? totalPrice + (price * quantity) : totalPrice + price;
                        isReadingQuantity = false;
                        isReadingName = true;
                        count = 0;
                    }
                }
            }
            
            totalPrice += isReadingName ? 0 : (quantity > 0 ? price * quantity : price);

            return totalPrice;
        }
    }
}
