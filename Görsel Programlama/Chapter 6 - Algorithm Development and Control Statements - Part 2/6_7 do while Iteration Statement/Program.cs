using System;

class Program{
    static void Main(){
        int counter = 1; // initialize counter
        
        do {
            Console.Write($"{counter} ");
            ++counter;
        } while (counter <= 10); // required semicolon
        
        Console.WriteLine();
    }
}