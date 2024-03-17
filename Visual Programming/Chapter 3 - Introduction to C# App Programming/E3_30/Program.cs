using System;

class Exercises
{
    static void Main()
    {
        int x, y, z, p, q;

        Console.Write("Enter the first integer\n> ");
        x = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the second integer\n> ");
        y = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the third integer\n> ");
        z = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the fourth integer\n> ");
        p = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the fifth integer\n> ");
        q = int.Parse(Console.ReadLine());
        
        int[] numbers = { x, y, z, p, q };

        foreach (int i in numbers){
            if (i > 0)
            {
                Console.WriteLine($"{i} is a positive number.");
            }
            else if (i < 0)
            {
                Console.WriteLine($"{i} is a negative number");
            }
            else if (i == 0)
            {
                Console.WriteLine($"{i} is a zero.");
            }
            else
            {
                Console.WriteLine("Invalid Value");
            }
        }
    }
}