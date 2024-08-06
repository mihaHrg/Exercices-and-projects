using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwOOP2.Exercise_5
{
    public class BankAccount1
    {
        private string accountNumber;
        private string accountHolder;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be set to a negative value.");
                }
            }
        }

        public BankAccount1 (string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
            Bank.NumAccounts++;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance >= 0) 
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insuficient funds!");
            }
        }
        public double GetInterest()
        {
            return Bank.CalculateInterest(Balance);
        }
    }
}
