using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class BankAccount
    {
        private string accountNumber;
        private double balance;

        public string AccoumtNumber
            {
            get { return accountNumber;} 
             }
        
        public double Balance
        {
            get { return balance;}
            private set
            {
                if (value > 0)
                balance = value;
            }
        }

        public BankAccount(string accNum, double initialBalance)
        {
            accountNumber = accNum;
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if
                (amount > 0 && amount <= balance)
                balance = amount;

            else
                Console.WriteLine("Invalid deposit amount.");
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance = amount;

            else
                Console.WriteLine("Invalid withdrawal amount.");
        }
    }
}
