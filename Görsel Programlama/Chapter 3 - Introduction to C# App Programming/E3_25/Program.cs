using System;

class Exercises {
    static void Main() {
        int x, y;
        Console.Write("Enter first integer\n> ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer\n> ");
        y = int.Parse(Console.ReadLine());

        if (x % y == 0) {
            Console.WriteLine(x % y);
        }
    }
}