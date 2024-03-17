using System;
class Program{
    static void Main(){
        Console.Write("Enter the distance in km\n> ");
        int distance = int.Parse(Console.ReadLine());
        double charge = 0;

        if (distance <= 5){
            charge = 13.0;
        }
        else if (distance > 5){
            Console.Write("Waiting time in minutes\n> ");
            int timeWaited = int.Parse(Console.ReadLine());
            double waitingFee = timeWaited * 0.5;
            charge = 13 + ((distance - 5) * 1.68) + waitingFee;
        }
        Console.WriteLine($"Cab Charge : ${charge}");
    }
}
