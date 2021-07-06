using System;
namespace Banking
{
    public class Account
    {
        public int Id { get; set; }
        public string Description { get; set; } = "New Account";
        public decimal Balance { get; private set; } = 0;

        public void Deposit(decimal Amount)
        {
            if (Amount <= 0)
            {
                throw new Exception("Amount must be positive.");    // Exception thrown if deposit is 
            }
            Balance += Amount;
        }

        public void Withdraw(decimal Amount)
        {
            if (Amount <= 0)
            {
                throw new Exception("Amount must be positive.");
            }
            if (Amount > Balance)
            {
                Console.WriteLine("Insufficient funds!");
                return; // Returns from method.
            }
            Balance -= Amount;
        }

    }
}
