using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    public class GetHeighestRate
    {
        private static void Sort(Tuple<string, int>[] movies, int stInd, int endInd)
        {
            if(stInd >= endInd)
            {
                return;
            }
            var pivot = stInd; 
            for (int i = stInd; i <= endInd; i++)
            {
                if(movies[i].Item2 < movies[pivot].Item2)
                {
                    if (pivot == i + 1)
                    {
                        var tmp = movies[pivot];
                        movies[pivot] = movies[i];
                        movies[i] = tmp;
                        pivot = i;
                    } else
                    {
                        var tmp = movies[pivot];
                        movies[pivot] = movies[i]; 
                        movies[i] = movies[pivot + 1];
                        movies[pivot + 1] = tmp;
                        pivot = pivot + 1;
                    }
                }
            }
            Sort(movies, stInd, pivot - 1);
            Sort(movies, pivot + 1, endInd);
        }

        public static string[] GetTopMovies(Tuple<string, int>[] movies)
        {
            Sort(movies, 0, movies.Length - 1);
            var set = new HashSet<string>();

            var result = new string[10];
            var count = 0;

            for (var j = movies.Length - 1; j >= 0; j--)
            {
                if(!set.Contains(movies[j].Item1) && count < 10)
                {
                    set.Add(movies[j].Item1);
                    result[count] = movies[j].Item1;
                    count++;
                }
             }

            return result;
        }
    }
}
