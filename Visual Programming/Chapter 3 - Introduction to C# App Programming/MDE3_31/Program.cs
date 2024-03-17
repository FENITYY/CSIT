using System;

class MakingDifferenceExercise
{
    static void Main()
    {
        int averageMonthlySaving, averageMonthlyIncome;
        double savingRatio;

        Console.WriteLine("Enter your average monthly saving\n> ");
        averageMonthlySaving = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your average monthly saving\n> ");
        averageMonthlyIncome = int.Parse(Console.ReadLine());

        savingRatio = averageMonthlySaving / averageMonthlyIncome;
        Console.WriteLine($"Your saving ratio is {savingRatio}");

        if (savingRatio < 0.2)
        {
            Console.WriteLine("Extravagant or Low on Savings");
            return;
        }
        else if (savingRatio > 0.2 && savingRatio < 0.4)
        {
            Console.WriteLine("Less Extravagant or Moderate on Savings");
            return;
        }
        else if (savingRatio > 0.4 && savingRatio < 0.75)
        {
            Console.WriteLine("Lively or Strong on Savings");
            return;
        }
        else if (savingRatio > 0.75)
        {
            Console.WriteLine("Miser or Mad about Savings");
            return;
        }

    }   
}