using System;

class Program{
    static void Main(){
        int y = 5;
        int z;

        Console.WriteLine($"Original value of y: {y}");
        Console.WriteLine("Original value of z: uninitialized\n");

        SquareRef(ref y);
        SquareOut(out z);

        Console.WriteLine($"Value of y after SquareRef: {y}");
        Console.WriteLine($"Value of z after SquareOut: {z}\n");

        Square(y);
        Square(z);

        Console.WriteLine($"Value of y after Square: {y}");
        Console.WriteLine($"Value of z after Square: {z}");
    }

    static void SquareRef(ref int x){
        x = x * x;
    }
    static void SquareOut(out int x){
        x = 6;
        x = x * x;
    }
    static void Square(int x){
        x = x * x;
    }
}