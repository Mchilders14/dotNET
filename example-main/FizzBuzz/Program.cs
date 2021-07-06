using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 31; i++)
            {
                Console.WriteLine(i);

                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FIZZBUZZ\n");
                }
                else if (i % 3 == 0) {
                    Console.WriteLine("FIZZ\n");
                }
                else if (i % 5 == 0) {
                    Console.WriteLine("BUZZ\n");
                }
                
            }
        }
    }
}
