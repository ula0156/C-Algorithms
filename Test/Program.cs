using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Person
    {
        public string name;
        public int age;

        public override string ToString()
        {
            return $"Hi, my name is {name} and I am {age} years old.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new Person();
            a.name = "Liviu";
            a.age = 30;

            Console.WriteLine(a);

            Console.ReadLine();
        }
    }


}
