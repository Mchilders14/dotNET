using System;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Bowling();
            Console.WriteLine($"Game score is: {game.Bowl()}");
        }
    }
}
