using System;
using System.Runtime.CompilerServices;

namespace E4_13
{
    internal class Account
    {
        public string Name { get; set; }
        private decimal balance;

        public Account(string accountName, decimal accountBalance) {
            Name = accountName;
            balance = accountBalance;
        }

        public decimal Balance
        {
            get { return balance; }
            private set { 
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal depositAmount)
        {
            Balance = Balance + depositAmount;
        }

        static void DisplayAccount(Account accountToDisplay)
        {
            Console.WriteLine($"{accountToDisplay}'s Balance : {accountToDisplay.Balance}");
        }
    }
}
