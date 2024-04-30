using System;

class Exercises
{
    static void Main()
    {
        Console.WriteLine("Enter a number\n> ");
        int number = int.Parse(Console.ReadLine());

        int i = 0, oneToTen = 0;
        while (i < 10)
        {
            oneToTen++;
            Console.WriteLine($"{number}    *   {oneToTen}  =   {number * oneToTen}");
            i++;
        }

    }
}