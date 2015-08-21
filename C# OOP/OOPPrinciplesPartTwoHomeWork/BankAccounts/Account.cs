namespace BankAccounts
{
    public abstract class Account
    {
        protected decimal balance;
        protected decimal interestRate;
        public Customer Customer { get; set; }

        public virtual decimal CalculateInterest(int months, decimal interestRate)
        {
            return months * interestRate;
        }
    }
}
