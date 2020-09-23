using System;

namespace Banking.Models.Domein
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime DateOfTrans { get; }
        public TransactionType TransactionType { get; }
        public bool isDeposit { get { return TransactionType == TransactionType.Deposit; } }

        public Transaction(decimal amount, TransactionType type)
        {
            Amount = amount;
            TransactionType = type;
            DateOfTrans = DateTime.Now;
        }
    }
}
