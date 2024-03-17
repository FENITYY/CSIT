# **Identify and correct the errors in each of the following statements.**

**a) Original Code**
```
if (c < 7);
{
   Console.WriteLine("c is less than 7");
} 
```

**Solution :** Remove semicolon on the end of the if statement line.
```
if (c < 7){
    Console.WriteLine("c is less than 7");
}
```

**b) Original Code**
```
if (c => 7) 
{
   Console.WriteLine("c is equal to or greater than 7");
}
```

**Solution :** Change the places of = and > in the if statement.
```
if (c >= 7){
   Console.WriteLine("c is equal to or greater than 7");
}
```