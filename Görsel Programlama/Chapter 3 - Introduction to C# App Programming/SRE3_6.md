# **Using the statements you wrote in Exercise 3.5, write a complete app that calculates and displays the product of three integers.**

```
using System;

class Product{
    static void Main(){
        int x, y, z, result;

        Console.Write("First Integer : ");
        x = int.Parse(Console.ReadLine());

        Console.Write("Second Integer : ");
        y = int.Parse(Console.ReadLine());

        Console.Write("Third Integer : ");
        z = int.Parse(Console.ReadLine());

        result = x * y * z;
        Console.WriteLine(Result : {result});
    }
}
```