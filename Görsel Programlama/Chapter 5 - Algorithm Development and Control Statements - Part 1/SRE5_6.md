*Combine the statements that you wrote in Exercise 5.5 into a C# app that calculates anddisplays the sum of the integers from 1 to 10. Use a while statement to loop through the calculationand increment statements. The loop should terminate when the value of x becomes 11.*

```
using System;

class Program{
    static void Main(){
        int sum;
        int x = 1;
        
        while (x <= 10){
            sum += x;
            ++x;
        }

        Console.WriteLine($"The sum is: {sum}");
    }
}
```