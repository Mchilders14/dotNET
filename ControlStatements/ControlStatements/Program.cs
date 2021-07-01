using System;

namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control Statements");

            int number = 3;

            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    break;
            }


            Console.WriteLine("Console App End");
        }
    }
}
