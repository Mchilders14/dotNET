using System;

namespace ExceptionsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr % 2 == 1) throw new OddNumberException();

            } while (Console.ReadLine().ToLower() != "y");
        }
    }
}
