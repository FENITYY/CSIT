using System;
using System.Runtime.Intrinsics.X86;

class Exercises{
    static void Main(){
        // Use one Console.WriteLine statement.
        Console.WriteLine("1 2 3 4");

        // Use four Console.Write statements.
        Console.Write("1");
        Console.Write(" 2");
        Console.Write(" 3");
        Console.Write(" 4\n");

        // Use one Console.WriteLine statement with four int variables and string interpolation.
        int k, l, m, n;
        k = 1;
        l = 2;
        m = 3;
        n = 4;
        Console.WriteLine($"{k} {l} {m} {n}");
    }
}