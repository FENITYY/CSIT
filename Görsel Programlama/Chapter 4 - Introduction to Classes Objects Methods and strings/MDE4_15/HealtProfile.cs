using System;

namespace MDE4_15
{
    internal class HealtProfile
    {
        private string nameFirst {  get; set; }
        private string nameLast { get; set; }
        private string gender { get; set; }
        private int birthDay { get; set; }
        private int birthMonth { get; set; }
        private int birthYear { get; set; }
        private int height { get; set; }
        private int weight { get; set; }

        public HealtProfile(string nf, string nl, string g, int bd, int birthMonth, int by, int weight, int height) {
            this.nameFirst = nf;
            this.nameLast = nl;
            this.gender = g;
            this.birthDay = bd;
            this.birthMonth = birthMonth;
            this.birthYear = by;
            this.weight = weight;
            this.height = height;
        }

        public int Age()
        {
            int yearCurrent = 2023;
            return yearCurrent - birthYear;
        }

        public int CalculateMHR()
        {
            return (int)(220 - Age());
        }

        private int CalculateRHR()
        {
            if (gender == "male")
            {
                return (int)(50 + (0.15 * Age()));
            }
            else if (gender == "female")
            {
                return (int)(50 + (0.14 * Age()));
            }
            else
            {
                throw new ArgumentException("Invalid gender. Please provide either 'male' or 'female'.");
            }
        }

        public int CalculateTHR()
        {
            int Intencity = 60;
            return (int)((CalculateMHR() - CalculateRHR() * Intencity) + CalculateRHR());
        }

        public int CalculateBMI()
        {
            return (int)((703 * weight) / Math.Pow(height, 2)); 
        }

        public void GetID()
        {
            Console.WriteLine($"\n/// {nameFirst}'s ID \\\\\\");
            Console.WriteLine($"Name = {nameFirst} {nameLast}");
            Console.WriteLine($"Date of Birth = {birthDay}.{birthMonth}.{birthYear}");
            Console.WriteLine($"Gender = {gender}");
            Console.WriteLine($"Weight = {weight} pounds");
            Console.WriteLine($"Height = {height} inches");
        }

        public void GetReport()
        {
            Console.WriteLine($"\n/// {nameFirst}'s Health Report \\\\\\");
            Console.WriteLine($"Age = {Age()}");
            Console.WriteLine($"BMI = {CalculateBMI()}");
            Console.WriteLine($"Maximum Heart Rate = {CalculateMHR()}");
            Console.WriteLine($"Target Heart Rate = {CalculateTHR()}");
        }
    }
}
