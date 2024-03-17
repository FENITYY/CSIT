using System;
using System.Transactions;

class Exercises
{
    static void Main()
    {
        Console.Write("Enter a five digit number\n> ");
        string value = Console.ReadLine();
        if (value.Length != 5 || !int.TryParse(value, out int number)) {
            Console.WriteLine("Invalid value");
            return;
        }
        foreach (char i in value)
        {
            Console.Write($"{i}    ");
        }
    }
}