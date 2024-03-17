*Identify and correct the errors in each of the following sets of code:*

**a)**
```
// Original Code

while (c <= 5) {
    product *= c;
    ++c;

/////////////////////////////////////

// Fixed Code

while (c <= 5) {
    product *= c;
    ++c;
} // Addded missing curly brace
```

**b)**

```
// Original Code

if (gender == 1)
{
    Console.WriteLine("Woman");
}
else; 
{
    Console.WriteLine("Man");
}

// Fixed Code

if (gender == 1) {
    Console.WriteLine("Woman");
}
else { // Removed semicolon
    Console.WriteLine("Man");
}
```