using System;
using System.Runtime.Versioning;

namespace MDE4_14
{
    internal class HeartRates
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int YearBirth { get; set; }

        public int YearCurrent { get; set; }

        public HeartRates(string fName, string lName, int YearB, int YearC) {
            this.FirstName = fName;
            this.LastName = lName;
            this.YearBirth = YearB;
            this.YearCurrent = YearC;
        }

        public int CalculateAge()
        {
            return YearCurrent - YearBirth;
        }

        public int CalculateMHR()
        {
            return (int)(220 - CalculateAge());
        }

        public int CalculateRHR() {
            return (int)(50 + (0.14 * CalculateAge()));
        }

        public int CalculateTHR()
        {
            int Intencity = 60;
            return (int)((CalculateMHR() - CalculateRHR() * Intencity) + CalculateRHR());
        }
    }
}
