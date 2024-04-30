using System;

namespace MDE4_14
{
    class HeartRatesTest
    {
        static void Main() { 
            HeartRates person = new HeartRates("Efe Can", "Kara", 2003, 2023);

            Console.WriteLine($"/// {person.FirstName}'s ID");
            Console.WriteLine($"Name : {person.FirstName} {person.LastName}");
            Console.WriteLine($"Age : {person.CalculateAge()}");

            Console.WriteLine($"\n/// {person.FirstName}'s Heart Rates");
            Console.WriteLine($"Maximum Heart Rate : {person.CalculateMHR()}");
            Console.WriteLine($"Minimum Heart Rate : {person.CalculateRHR()}");
            Console.WriteLine($"Target Heart Rate : {person.CalculateTHR()}");
        }
    }
}