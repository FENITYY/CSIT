using System;

class Program{
    static void Main(){
        // Propt user for the double radius of a sphere
        Console.Write("Enter radius value\n> ");
        double r = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Sphere Volume = {SphereVolume(r)}");
    }

    static double SphereVolume(double radius){
        return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
    }
}