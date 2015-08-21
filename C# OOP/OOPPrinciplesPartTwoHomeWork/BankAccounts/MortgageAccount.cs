namespace BankAccounts
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(decimal balance, decimal interestRate, Customer customer)
        {
            this.balance = balance;
            this.interestRate = interestRate;
            this.Customer = customer;
        }
        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        public override decimal CalculateInterest(int months, decimal interestRate)
        {
            if (months <= 12)
            {
                return months * interestRate / 2;
            }
            else
            {
                return (months - 12) * interestRate + 12 * interestRate / 2;
            }
        }
    }
}
