using Banking.Models.Domein;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123-4567890-12");
            account.Deposit(200M);
            Console.WriteLine(WriteBalance(account));
            account.Withdraw(100M);
            Console.WriteLine(WriteBalance(account));
        }

        private static string WriteBalance(BankAccount account)
        {
            return $"Balance is {account.Balance}";
        }
    }
}
