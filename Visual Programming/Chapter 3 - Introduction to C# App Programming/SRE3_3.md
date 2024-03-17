# **Write statements to accomplish each of the following tasks.**

**a)** Declare variables c, thisIsAVariable, q76354 and number to be of type int.

```
int c, thisIsAVariable, q76354, number;
```

**b)** Prompt the user to enter an integer

```
Console.WriteLine("Enter an integer value : ");
```

**c)** Input an integer and assign the result to int variable value.

```
int intValue = int.Parse(Console.ReadLine())
```

**d)** If the variable number is not equal to 7, display "The variable number is not equal to 7".

```
if (number != 7){
    Console.WriteLine("The variable number is not equal to 7.");
}
```

**e)** Display "This is a C# app" on one line in the console window.

```
Console.WriteLine("This is a C# app");
```

**f)** Display "This is a C# app" on two lines in the console window. The first line should end with C#. Use method Console.WriteLine.

```
Console.WriteLine("This is a C#\napp");
```

**g)** Write a statement that uses string interpolation to display the sum of the variables x and y. Assume variables x and y of type int exist and already have values.

```
Console.WriteLine("The sum is {x+y}");
```