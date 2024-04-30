using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Exercises{
    static void Main(){
        // User inputs
        int x, y, z;
        Console.Write("Enter first integer\n> ");
        x = int.Parse(Console.ReadLine());
        Console.Write("Enter second integer\n> ");
        y = int.Parse(Console.ReadLine());
        Console.Write("Enter third integer\n> ");
        z = int.Parse(Console.ReadLine());
        int[] variables = { x, y, z };

        // Arithmetic Operations
        int sum, average, product, smallest, largest;

        sum = x + y + z;
        average = (x + y + z) / 3;
        product = x * y * z;
        smallest = variables.Min();
        largest = variables.Max();

        // Output results
        Console.WriteLine($"Sum         = {sum}");
        Console.WriteLine($"Average     = {average}");
        Console.WriteLine($"Product     = {product}");
        Console.WriteLine($"Smallest    = {smallest}");
        Console.WriteLine($"Largest     = {largest}");
    }
}