using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var sav1 = Savings.OpenSavingsAccount(200);
            Console.WriteLine($"Balance is: {sav1.Balance}");

            var sav2 = new Savings(300);
            Console.WriteLine($"Balance is: {sav2.Balance}");

            sav2.Withdraw(50);
            Console.WriteLine($"Balance is: {sav2.Balance}");

            //sav2.Withdraw(100);
            //Console.WriteLine($"Balance is: {sav2.Balance}");

            //var account = new Account()
            //{
            //    Id = 123,
            //    Description = "Matt's Account"
            //};

            //account.Deposit(1000);
            //account.Withdraw(300);

            //Console.WriteLine($"Balance is: {account.Balance}");

            //account.Deposit(-200);
            //Console.WriteLine($"Balance is: {account.Balance}");


        }
    }
}
