// hesaptaki para belirtilecek.
// hesaptan para cekilecek
// kalan para gosterilecek
using System;

public class Account
{
    private double moneyCurrent;

    public Account(double mainMoney)
    {
        if (mainMoney > 0)
        {
            moneyCurrent = mainMoney;
        }
    }

    public void Withdraw(double moneyWithdrawed)
    {
        if (moneyWithdrawed > moneyCurrent) {
            Console.WriteLine("Withdrawal amount exceeded account balance.");
        }
        else
        {
            moneyCurrent -= moneyWithdrawed;
        }
    }
    public double CurrentMoney()
    {
        return moneyCurrent;
    }
}