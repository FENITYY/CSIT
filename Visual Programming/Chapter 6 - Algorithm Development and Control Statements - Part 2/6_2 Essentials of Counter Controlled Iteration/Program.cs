using System;
class WhileCounter {
    static void Main() {
        int counter = 1;
        while (counter <= 10) {
            Console.Write($"{counter} ");
            ++counter;
        }
        Console.WriteLine();
    }
}

