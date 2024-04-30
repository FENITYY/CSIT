using System;

class Program {
    static void Main() {
        int count;
        
        for (count = 1; count <= 10; ++count) {
            if (count == 5) {
                break;
            }
            Console.Write($"{count}");
        }
        Console.WriteLine($"\nBroke out of loop at count = {count}");
    }
}