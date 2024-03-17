using System;

class MakingDifferenceExercise
{
    static void Main()
    {
        // formula
        // drivingCost = (drivingDistance / averageMPG ) * gasolineCost + parkingFee + tolls;

        double drivingCost, averageMPG, gasolineCost;
        int drivingDistance, parkingFee, tolls;

        Console.Write("Enter the distance you drived in miles.\n> ");
        drivingDistance = int.Parse(Console.ReadLine());
        Console.Write("Enter the average miles per galoon.\n> ");
        averageMPG = double.Parse(Console.ReadLine());
        Console.Write("Enter the cost of one galoon of gasoline.\n> ");
        gasolineCost = double.Parse(Console.ReadLine());
        Console.Write("Enter the parking fees per day.\n> ");
        parkingFee = int.Parse(Console.ReadLine());
        Console.Write("Enter the tolls per day.\n> ");
        tolls = int.Parse(Console.ReadLine());

        drivingCost = (drivingDistance / averageMPG) * gasolineCost + parkingFee + tolls;
        Console.WriteLine($"Your daily driving cost is aproximately ${drivingCost}");
        }
}