**Write  an  app  that  tests  whether  the  examples  of  the  Math  class  method  calls  shown  in Fig. 7.2 actually produce the indicated results.**

```
using System;

class Program{
    static void Main(){
        Console.WriteLine($"Math.Abs(23.7) = {Math.Abs(23.7)}");
        Console.WriteLine($"Math.Abs(0.0) = {Math.Abs(0.0)}");
        Console.WriteLine($"Math.Abs(-23.7) = {Math.Abs(-23.7)}");
        Console.WriteLine($"Math.Ceiling(9.2) = {Math.Ceiling(9.2)}");
        Console.WriteLine($"Math.Ceiling(-9.8) = {Math.Ceiling(-9.8)}");
        Console.WriteLine($"Math.Cos(0.0) = {Math.Cos(0.0)}");
        Console.WriteLine($"Math.Exp(1.0) = {Math.Exp(1.0)}");
        Console.WriteLine($"Math.Exp(2.0) = {Math.Exp(2.0)}");
        Console.WriteLine($"Math.Floor(9.2) = {Math.Floor(9.2)}");
        Console.WriteLine($"Math.Floor(-9.8) = {Math.Floor(-9.8)}");
        Console.WriteLine($"Math.Log(Math.E) = {Math.Log(Math.E)}");
        Console.WriteLine($"Math.Log(Math.E * Math.E) = {Math.Log(Math.E * Math.E)}");
        Console.WriteLine($"Math.Max(2.3, 12.7) = {Math.Max(2.3, 12.7)}");
        Console.WriteLine($"Math.Max(-2.3, -12.7) = {Math.Max(-2.3, -12.7)}");
        Console.WriteLine($"Math.Min(2.3, 12.7) = {Math.Min(2.3, 12.7)}");
        Console.WriteLine($"Math.Min(-2.3, -12.7) = {Math.Min(-2.3, -12.7)}");
        Console.WriteLine($"Math.Pow(2.0, 7.0) = {Math.Pow(2.0, 7.0)}");
        Console.WriteLine($"Math.Pow(9.0, 0.5) = {Math.Pow(9.0, 0.5)}");
        Console.WriteLine($"Math.Sin(0.0) = {Math.Sin(0.0)}");
        Console.WriteLine($"Math.Sqrt(900.0) = {Math.Sqrt(900.0)}");
        Console.WriteLine($"Math.Tan(0.0) = {Math.Tan(0.0)}");
    }
}
```