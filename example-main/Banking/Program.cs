using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account()
            {
                Id = 123, Description = "Matt's Account"
            };

            account.Deposit(1000);
            account.Withdraw(300);

            Console.WriteLine($"Balance is: {account.Balance}");

            account.Deposit(-200);
            Console.WriteLine($"Balance is: {account.Balance}");


        }
    }
}
