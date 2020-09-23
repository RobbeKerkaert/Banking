using System;
using System.Collections;
using System.Collections.Generic;

namespace Banking.Models.Domein
{
    public class BankAccount
    {
        private readonly System.Collections.IList _transactions;
        #region Properties
        public decimal Balance { get; private set; } = 0M;
        public string AccountNumber { get; }
        public int NumberOfTransactions { get { return _transactions.Count; } }
        #endregion

        #region Constructor
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
            _transactions = new List<Transaction>();
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
            _transactions.Add(new Transaction(amount, TransactionType.Deposit));
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
        }

        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
