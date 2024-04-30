using System;

class Program{
    static void Main(){
        int totalInterests = 0;
        double combinedInterest = 0;

        Console.WriteLine("Enter investments details. Use negative value to exit)");

        while (true){
            Console.Write("Amount Invested (negative value to exit)\n> ");
            string amountInput = Console.ReadLine();
            
            if (!int.TryParse(amountInput, out int amount)){
                Console.WriteLine("Enter a valid value");
                continue;
            }

            if (amount < 0){
                break;
            }

            Console.Write("Interest Earned (negative value to exit)\n> ");
            string interestInput = Console.ReadLine();

            if (!int.TryParse(interestInput, out int interest)){
                Console.WriteLine("Enter a valid value");
                continue;
            }
            
            combinedInterest = amount * interest / 100.0;
            totalInterests += (int)Math.Round(combinedInterest, 2);
            Console.WriteLine($"Combined interest for this investment: {combinedInterest:C}");
        }

        Console.WriteLine($"Total combined interests for all investments: {totalInterests:C}");
    }
}