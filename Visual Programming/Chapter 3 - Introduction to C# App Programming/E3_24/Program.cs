using System;

class Exercises{
    static void Main() {
        Console.WriteLine("Enter an integer value\n> ");
        int x = int.Parse(Console.ReadLine());
        if (x % 2 == 0){
            Console.WriteLine("Value is even.");
        }
        else if (x % 2 != 0) {
            Console.WriteLine("Value is odd");
        }
        else {
            Console.WriteLine("Invalid Value");
        }
     }
}