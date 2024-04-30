using System;

class Exercises{
    static void Main() {
        double pi = Math.PI;
        double circumference, area;
        int r, diameter;

        Console.Write("Radius : ");
        r = int.Parse(Console.ReadLine());

        diameter = 2 * r;
        circumference = 2 * pi * r;
        area = pi * Math.Pow(r, 2);

        Console.WriteLine($"Diameter : {diameter}");
        Console.WriteLine($"Circumference : {circumference}");
        Console.WriteLine($"Area : {area}");
    }
}