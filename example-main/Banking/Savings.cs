using System;
namespace Banking
{
    public class Savings : Account
    {

        public decimal InterestRate { get; set; } = 0.12m;  // 'm' modifier required if variable is of type decimal.
        private static decimal MinBalance { get; set; } = 200m; // Using static modifier to allow for use in static method and belongs to class

        private Savings() { }   // *Required* MIN BALANCE so cannot use default constructor.

        public Savings(decimal OpenAmountDeposit)   // New constructor with min balance requirement
        {
            if (OpenAmountDeposit < MinBalance)
            {
                throw new Exception($"Opening savings requires {MinBalance} deposit.");
            }
            Deposit(OpenAmountDeposit);
        }

        public override void Withdraw(decimal Amount)   // 'Override' keyword - change method from parent class.
        {
            if (Balance - Amount < MinBalance)
            {
                throw new Exception($"Amount to withdraw must be <= {Balance - MinBalance}");
            }
            base.Withdraw(Amount);
        }

        public decimal CalculateInterest(int Months)
        {
            var interestAmount =  Balance * (InterestRate / 12) * Months;
            Deposit(interestAmount);
            return interestAmount;
        }

        public static Savings OpenSavingsAccount(decimal OpenAmountDeposit)     // Creation of constructor with min balance will make this redundant.
        {
            if (OpenAmountDeposit < MinBalance)
            {
                throw new Exception($"Opening savings requires {MinBalance} deposit.");
            }
            var savings = new Savings();
            savings.Deposit(OpenAmountDeposit);
            return savings;
        }

    }
}
