*Find the error(s) in each of the following code segments and explain how to correct it*

**a)**

```
// Original Code

i = 1;
while (i <= 10);
    ++i;
}

// Fixed Code

i = 1;
while (i <= 10) 
{ // Replace semicolon with curly braces
    ++i;
}
```

**b)**

```
// Original Code

for (k = 0.1;k != 1.0; k += 0.1)
{
    Console.WriteLine(k);
}

// Fixed Code

for (k = 1;k != 10; ++k) // Change float values with integers (Floats could cause problems)
{
    Console.WriteLine((double) k / 10); // Cast output value from int to double
}
```

**c)**

```
// Original Code

switch (n)
{
    case 1:
        Console.WriteLine("The number is 1");
    case 2:
        Console.WriteLine("The number is 2");
        break;
    default:
        Console.WriteLine("The number is not 1 or 2");
        break;
}

// Fixed Code

switch (n) {
    case 1:
        Console.WriteLine("The number is 1");
        break; // break statement added.
    case 2:
        Console.WriteLine("The number is 2");
        break;
    default:
        Console.WriteLine("The number is not 1 or 2");
        break;
}
```

**d)**

```
// Original Code

// The following code should display the values 1 to 10:
n = 1;
while (n < 10)
{
    Console.WriteLine(n++);
}

// Fixed Code

// The following code should display the values 1 to 10:
n = 1;
while (n < 11) // Number Correction
{
    Console.WriteLine(n++);
}
```