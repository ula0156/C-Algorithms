using System;
using System.Collections.Generic;
using System.Linq;

namespace Test.Array
{
    public class Amazon1
    {
        public static int IsWinner(List<List<string>> codeList, List<string> shoppingCart)
        {

            if (codeList.Count == 0)
            {
                return 1;
            }

            var indexCart = 0;

            foreach (var list in codeList)
            {
                var i = 0;
                var stIndex = -1;

                while (indexCart < shoppingCart.Count && list.Count < i)
                {
                    if (list[i] == shoppingCart[indexCart] || list[i] == "anything")
                    {
                        if (stIndex == -1)
                        {
                            stIndex = indexCart;
                        }

                        indexCart++;
                        i++;
                    }

                    else if (list[i] != shoppingCart[indexCart] && list[i] != "anything")
                    {
                        if (stIndex != -1)
                        {
                            if (stIndex + 1 >= shoppingCart.Count)
                                return 0;

                            stIndex += 1;
                            i = 0;
                        }
                        else
                        {
                            indexCart++;
                        }

                    }
                }
                if (i < list.Count)
                {
                    return 0;
                }

            }

            return 1;
        }

        //RecusiveSolution

        private static bool CheckList(List<string> list, int i, List<string> shoppingCart, int j)
        {
            if (shoppingCart.Count == 0 || (j == shoppingCart.Count && i < list.Count))
            {
                return false;
            } 
            if (i == list.Count)
            {
                shoppingCart.RemoveRange(0, list.Count);
                return true;
            }
            if (list[i] == list[j] || list[i] == "anything")
            {
                return CheckList(list, i + 1, shoppingCart, j + 1);
            }

            shoppingCart.RemoveRange(0, j);
            return CheckList(list, 0, shoppingCart, 0);
        }

        public static int IsWinner2(List<List<string>> codeList, List<string> shoppingCart)
        {

            if (codeList.Count == 0)
            {
                return 1;
            }

            if (!CheckList(codeList[0], 0, shoppingCart, 0))
            {
                return 0;
            }

            codeList.RemoveAt(0);
            return IsWinner2(codeList, shoppingCart);
        }
    }
}
