using System;

namespace Change_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            do
            {
                var cents = EnterCents();
                var origCents = cents;

                var quarters = cents / 25;
                cents -= quarters * 25;
                var dimes = cents / 10;
                cents -= dimes * 10;
                var nickels = cents / 5;
                cents -= nickels * 5;
                var pennies = cents;

                Console.WriteLine($"{origCents} cents is {quarters} quarters, {dimes} dimes, {nickels} nickels and {pennies} pennies.");

                done = AskIfDone();

            } while (!done);
        }

        static bool AskIfDone()
        {
            Console.Write("Are you done(y/n)?");
            var answer = Console.ReadLine().ToLower() == "y";  // Boolean expression, read input and convert to lowercase.
            return answer;
        }

        static int EnterCents()
        {
            Console.Write("Enter the number of cents: ");
            var centsStr = Console.ReadLine();
            var cents = Int32.Parse(centsStr);
            return cents;

        }
    }
}
