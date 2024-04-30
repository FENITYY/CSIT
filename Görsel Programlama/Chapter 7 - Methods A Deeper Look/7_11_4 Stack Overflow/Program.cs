using System;

class Program{
    static void Main(){
        int x = 10;
        Console.WriteLine($"x squared : {Square(x)}");
    }

    static int Square(int y){
        return y * y;
    }
}