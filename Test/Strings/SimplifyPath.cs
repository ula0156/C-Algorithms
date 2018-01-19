using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Strings
{
    public class SimplifyPath
    {
        public static string TrySimplifyPath(string path)
        {
            if (path == "")
            {
                return null;
            }

            string[] directories = path.Split('/');
            // remove all the empry spaces
            directories = directories.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            var stack = new Stack<string>();

            foreach (var directory in directories)
            {

                if (directory != ".." && directory != ".")
                {
                    stack.Push(directory);
                }
                else if (directory == ".." && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (directory == "...")
                {
                    stack.Push(directory);
                }
            }

            if (stack.Count == 0)
            {
                if (path[0] == '/')
                {
                    return "/";
                }
                return null;
            }

            var result = new string[stack.Count * 2];
            result[0] = "/";
            var index = result.Length - 1;
            while (stack.Count > 0)
            {
                if (index % 2 == 0)
                {
                    result[index] = "/";
                }
                else
                {
                    result[index] = stack.Pop();
                }
                index--;
            }

            return string.Join("", result);
        }
    }
}
