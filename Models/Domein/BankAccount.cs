namespace Banking.Models.Domein
{
    public class BankAccount
    {
        #region Properties
        public decimal Balance { get; private set; } = 0M;
        public string AccountNumber { get; }
        #endregion

        #region Constructor
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}
