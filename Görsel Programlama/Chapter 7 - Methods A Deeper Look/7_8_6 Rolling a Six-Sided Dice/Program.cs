using System;

class Program{
    static void Main(){
        Random randomNumbers = new Random();

        for (int counter = 1; counter <= 20; ++counter){
            int face = randomNumbers.Next(1, 7);
            Console.Write($"{face}\t");
        }
        Console.WriteLine();
    }
}