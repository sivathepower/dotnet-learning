namespace Banking
{

    public class Account
    {
        private decimal balance;
        public event AccountOperation accountInfo;
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                decimal newBalance = Balance - amount;
                if (newBalance < 500)
                {
                    accountInfo();
                }
                Balance = newBalance;
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }
    }
}