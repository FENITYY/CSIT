using System;

class Exercises{
    static void Main() {
        int day;
        Console.Write("What day of the week?\n>");
        day = int.Parse(Console.ReadLine());
        if (day >= 1 && day <= 5) {
            Console.WriteLine("It's working day.");
        }
        else if (day >= 6 && day <= 7) {
            Console.WriteLine("It's weekend.");
        }
        else{
            Console.WriteLine("Invalid value.");
        }
    }
}