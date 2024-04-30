*Write a C# statement or a set of C# statements to accomplish each of the following tasks:*

**a)** Sum the odd integers between 1 and 99, using a for statement. Assume that the integer variables sum and count have been declared.

```
int sum = 0;
for (x = 1;x <= 99; x += 2){
    sum += x;
}
```

**b)** Calculate the value of 2.5 raised to the power of 3, using the Pow method.

```
Math.Pow(2.5, 3);
```

**c)** Display the integers from 1 to 20 using a while loop and the counter variable i. Assumethat the variable i has been declared, but not initialized. Display only five integers per line. [Hint: Use the calculation i % 5. When the value of this expression is 0, display a newline  character;  otherwise,  display  a  tab  character.  Use  the  Console.WriteLine() method to output the newline character, and use the Console.Write(’\t’) method to output the tab character.]

```
i = 1;
while (i <= 20){
    Console.Write(i);

    if (i % 5 == 0) {
        Console.WriteLine();
    }
    else {
        Console.Write("\t)
    }

    ++i;
}
```

**d)** Repeat part (c), using a for statement.

```
for (i = 1;i <= 20; ++i){
    Console.Write(i);

    if (i % 5 == 0) {
        Console.WriteLine();
    }
    else {
        Console.Write("\t)
    }
}
```