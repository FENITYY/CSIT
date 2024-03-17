using System;

class Interest{
    static void Main(){
        decimal principal = 1000;
        double rate = 0.05;

        Console.WriteLine("Year\tAmount on Deposit");

        for (int year = 1; year <= 10; ++year){
            decimal amount = principal * ((decimal) Math.Pow(1.0 + rate, year));
            Console.WriteLine($"{year,4}{amount,20:C}");
        }
    }
}