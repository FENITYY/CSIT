*Find the error(s) in each of the following code segments. Explain how to correct the error.*

**a)**

```
// Original Code

void G()
{
    Console.WriteLine("Inside method G");
    void H()
    {
        Console.WriteLine("Inside method H");
    }
}

// Fixed Code

void G()
{
    Console.WriteLine("Inside method G");
}
void H(){ // 
    Console.WriteLine("Inside method H");
}

// Seperate method declarations
```

**b)**

```
// Original Code

int Sum(int x, int y)
{
    int result;
    result = x + y
}

// Fixed Code

int Sum(int x, int y)
{
    int result = x + y;
    return result;
}

```

**c)**

```
// Original Code

void F(float a);
{
    float a;
    Console.WriteLine(a);
}

// Fixed Code

void F(float a) // Remove semicolon
{
    float a = 0.0f; // Variable needs an float value
    Console.WriteLine(a);
}

```

**d)**

```
// Original Code

void Product(){
    int a = 6, b = 5, c = 4, result;
    result a * b * c;
    Console.WriteLine("Result is " + result);
    return result;
}

// Fixed Code

int Product(){ // for int returned value 
    int a = 6, b = 5, c = 4, result;
    result a * b * c;
    Console.WriteLine("Result is " + result);
    return result;
}
```
