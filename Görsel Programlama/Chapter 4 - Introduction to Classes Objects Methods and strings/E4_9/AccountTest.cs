// para cekme fonksiyonlari calistirilacak

using System;

class AccountTest
{
    static void Main()
    {
        Account account = new Account(100.0);
        Console.WriteLine($"Your current money : ${account.CurrentMoney()}");

        account.Withdraw(51.0);
        Console.WriteLine($"Your current money : ${account.CurrentMoney()}");

        account.Withdraw(51.0);
        Console.WriteLine($"Your current money : ${account.CurrentMoney()}");
    }
}