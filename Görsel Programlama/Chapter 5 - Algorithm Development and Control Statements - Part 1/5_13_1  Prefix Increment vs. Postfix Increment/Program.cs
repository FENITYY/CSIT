// Fig. 5.16: Increment.cs
// Prefix increment and postfix increment operators.
using System;
class Programn {
    static void Main() {
            // demonstrate postfix increment operator
            int c = 5; // assign 5 to c
            Console.WriteLine($"c before postincrement: {c}");
            Console.WriteLine($"postincrementing c: {c++}");
            Console.WriteLine($" c after postincrement: {c}");
            
            Console.WriteLine(); 
            
            c = 5; // assign 5 to c
            Console.WriteLine($" c before preincrement: {c}");
            Console.WriteLine($"preincrementing c: {++c}");
            Console.WriteLine($" c after preincrement: {c}");
    }
}