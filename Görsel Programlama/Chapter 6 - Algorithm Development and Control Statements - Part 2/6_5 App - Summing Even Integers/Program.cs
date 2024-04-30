using System;

class Program{
    static void Main(){
        int total = 0;
        for (int number = 2; number <= 20; number += 2){
            total += number;
        }
        Console.WriteLine($"Sum is {total}"); // display results
    }
}