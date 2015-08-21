namespace BankAccounts
{
    public class LoanAccount : Account , IDepositable
    {
        public LoanAccount(decimal balance, decimal interestRate, Customer customer)
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
            if (this.Customer == Customer.Individual)
            {
                if (months >= 3)
                {
                    return (months - 3) * interestRate;
                }
                else
                {
                    return 0;
                }
            }
            else if (this.Customer == Customer.Company)
            {
                if (months >= 2)
                {
                    return (months - 2) * interestRate;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new System.InvalidOperationException("There is no such type Customer!");
            }
        }
    }
}
