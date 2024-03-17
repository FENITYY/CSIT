using System;

class Program{
    // Two dice that has six faces that hav valuse though 1 to 6.
    // Calculate sum of two dices faces value.
    
    // Point case
        // Win : 7, 11
        // Lose : 2, 3, 12
        // Possible points : 4, 5, 6, 8, 9, 10

    // Roll the dice until point case and  current dice face valuesum gets equal
    // If current dice face value sum is 7' player looses.

    private static Random randomNumbers = new Random();

    private enum Status {Continue, Win, Lose}

    private enum Dices{
        SnakeEyes = 2,
        Trey = 3,
        Seven = 7,
        YoLeven = 11,
        BoxCars = 12
    }

    static void Main(){
        Status gameCurrent = Status.Continue;

        int point = 0;
        int diceFaceValueSum = RollDice();

        // Case Expressions

        switch((Dices) diceFaceValueSum){
            // Sudden win cases
            case Dices.Seven:
            case Dices.YoLeven:
                gameCurrent = Status.Win;
                break;
            
            // Sudden lose case
            case Dices.SnakeEyes:
            case Dices.Trey:
            case Dices.BoxCars:
                gameCurrent = Status.Lose;
                break;
            
            // Point set case
            default:
                gameCurrent = Status.Continue;
                point = diceFaceValueSum;
                Console.WriteLine($"Point : {diceFaceValueSum}");
                break;
        }

        while (gameCurrent == Status.Continue){
            diceFaceValueSum = RollDice();
            if (diceFaceValueSum == point){
                gameCurrent = Status.Win;
            }
            else if (diceFaceValueSum == (int)Dices.Seven){
                gameCurrent = Status.Lose;
            }
        }

        if (gameCurrent == Status.Win){
            Console.WriteLine("Win");
        }
        else{
            Console.WriteLine("Lose");
        }
    }

    static int RollDice(){
        int d1 = randomNumbers.Next(1,7);
        int d2 = randomNumbers.Next(1,7);
        int sum = d1 + d2;

        Console.WriteLine($"Dice : |{d1}| |{d2}|");
        return sum;
    }
}