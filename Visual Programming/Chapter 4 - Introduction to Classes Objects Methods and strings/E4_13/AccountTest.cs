using System;

namespace E4_13
{
    class AccountTest
    {
        static void Main()
        {
            Account account1 = new Account("Jane Green", 50.00m);
            Account account2 = new Account("John Blue", -7.53m);

            DisplayAccount(account1);
            DisplayAccount(account2);

            AccountDeposit(account1);

            DisplayAccount(account1);
            DisplayAccount(account2);

            AccountDeposit(account2);

            DisplayAccount(account1);
            DisplayAccount(account2);
        }

        static void DisplayAccount(Account accountToDisplay)
        {
            Console.WriteLine($"{accountToDisplay.Name}'s Balance : {accountToDisplay.Balance}");
        }

        static void AccountDeposit(Account accountToDeposit)
        {
            Console.Write($"Enter deposit amount for {accountToDeposit.Name}\n> ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Adding ${depositAmount} to {accountToDeposit.Name}");
            accountToDeposit.Deposit(depositAmount);
        }
    }
}