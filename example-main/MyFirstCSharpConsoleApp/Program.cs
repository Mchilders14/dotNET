using System;
using System.Linq;

namespace MyFirstCSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "matt";
            var str = $"name is {name}";    // Interpolated string.

            int? number = null;     // Value types cannot be null. Types can allow null by appending a '?' to mark type.

            var hw = "Hello World!";

            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var odds = ints.Where(i => i % 2 != 0);

            foreach(int i in odds)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine(number);
            Console.WriteLine(hw);
            Console.WriteLine(str);
        }
    }
}
