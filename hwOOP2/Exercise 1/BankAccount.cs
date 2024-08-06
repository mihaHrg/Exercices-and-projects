using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace hwOOP2.Exercise_1
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }
        public List<Transaction> Transactions { get; set; }

        public BankAccount (int accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = 0;
            Transactions = new List<Transaction>();
        }

        public void Deposit (decimal amount)
        {
            Balance += amount;
            Transactions.Add(new Transaction(DateTime.Now, "deposit", amount));
        }
        public void Withdraw (decimal amount)
        {
            if (amount > Balance)
            {
                throw new InvalidOperationException("Insuficient funds!");
            }
            Balance -= amount;
            Transactions.Add(new Transaction (DateTime.Now,"withdraw",amount));
        }
        public decimal GetBalance()
        {
            return Balance;
        }

        public List <Transaction> GetTransactionHistory()
        {
            return Transactions.OrderBy(t => t.Timestamp).ToList();
        }

    }
}
