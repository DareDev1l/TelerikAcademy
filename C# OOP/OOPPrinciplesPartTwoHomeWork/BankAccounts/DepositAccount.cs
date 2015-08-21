namespace BankAccounts
{
    public class DepositAccount : Account , IDepositable, IWithdrawable
    {
        public DepositAccount(decimal balance, decimal interestRate, Customer customer)
        {
            this.balance = balance;
            this.interestRate = interestRate;
            this.Customer = customer;
        }
        public void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.balance -= amount;
        }

        public override decimal CalculateInterest(int months, decimal interestRate)
        {
            if (this.balance >= 0 && this.balance < 1000)
            {
                return 0;
            }
            else
            {
                return months * interestRate;
            }
        }
    }
}
