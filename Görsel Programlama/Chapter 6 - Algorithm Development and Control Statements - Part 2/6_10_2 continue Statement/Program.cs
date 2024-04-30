using System;

class Program {
    static void Main() {
        int count;
        
        for (count = 1; count <= 10; ++count) {
            if (count == 5) {
                continue;
            }
            Console.Write($"{count}");
        }
        Console.WriteLine("\nUsed continue to skip displaying 5");
    }
}