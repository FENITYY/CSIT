using System;

namespace E4_12
{
    internal class Coach
    {
        private string coachingType;
        private int playerCount;
        private string classTiming;
        private decimal charges;

        private string Type
        {
            get { return coachingType; }
            set { coachingType = value; }
        }

        private int CountPlayer
        {
            get { return playerCount; }
            set { playerCount = value; }
        }

        private string Timing
        {
            get { return classTiming; }
            set { classTiming = value; }
        }

        private decimal Charge
        {
            get { return charges; }
            set { charges = value; }
        }

        public Coach(string coachingType, int playerCount, string classTiming, decimal charges) {
            this.coachingType = coachingType;
            this.playerCount = playerCount;
            this.classTiming = classTiming;
            this.charges = charges;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("///// Coaching Details \\\\\\\\\\");
            Console.WriteLine($"Type > {coachingType}");
            Console.WriteLine($"Player Count > {playerCount}");
            Console.WriteLine($"Training Date > {classTiming}");
            Console.WriteLine($"Charge > ${charges}");
        }
    }
}

