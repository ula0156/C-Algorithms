using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public class ArrayOfProducts
    {
        public static int[] GetArrayOfProducts(int[] a)
        {
            if (a.Length <= 2)
            {
                throw new IndexOutOfRangeException("Getting the product of numbers at other indices requires at least 2 numbers");
            }
            var i = 0;
            var arrayOfProducts = new int[a.Length];

            var product_so_far = 1;
            while (i < a.Length)
            {
                arrayOfProducts[i] = product_so_far;
                product_so_far *= a[i];
            }

            product_so_far = 1;
            var j = arrayOfProducts.Length - 1;
            while(j >= 0)
            {
                arrayOfProducts[j] *= product_so_far;
                product_so_far *= a[j];
             }

            return arrayOfProducts;
        }
    }
}
