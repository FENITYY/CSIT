using System;

class Exercises{
    static void Main(){
        int item1, item2, item3, total;
        
        Console.Write("First products price : ");
        item1 = int.Parse(Console.ReadLine());
        Console.Write("Second products price : ");
        item2 = int.Parse(Console.ReadLine());
        Console.Write("Third products price : ");
        item3 = int.Parse(Console.ReadLine());

        total = (item1 + item3 + item3) - ((item1 + item2 + item3) * 10) / 100;
        Console.WriteLine($"Discounted total price is {total}");
    }
}