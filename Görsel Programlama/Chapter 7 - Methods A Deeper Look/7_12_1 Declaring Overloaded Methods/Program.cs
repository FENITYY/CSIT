using System;

class Program{
    static void Main(){
        Console.WriteLine($"Square of integer 7 is {Square(7)}");
        Console.WriteLine($"Square of double 7.5 is {Square(7.5)}");
    }

    static int Square(int intValue){
        Console.WriteLine($"Called square with int argument: {intValue}");
        return intValue * intValue;
    }

    static double Square(double doubleValue){
        Console.WriteLine($"Called square with int argument: {doubleValue}");
        return doubleValue * doubleValue;
    }
}