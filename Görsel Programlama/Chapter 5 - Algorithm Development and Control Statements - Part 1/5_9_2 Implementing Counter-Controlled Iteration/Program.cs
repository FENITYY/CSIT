using System;

class Program{
    static void Main(){
        int total = 0;
        int gradeCounter = 0;

        while (gradeCounter <= 10) {
            Console.Write("Enter grade: ");
            int grade = int.Parse(Console.ReadLine()); 
            total = total + grade; 
            gradeCounter = gradeCounter + 1; 
        }

        int average = total / 10;
        Console.WriteLine($"\nTotal of all 10 grades is {total}");
        Console.WriteLine($"Class average is {average}");
    }
}