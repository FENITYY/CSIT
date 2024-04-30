// Student ID
// Name
// Grades from 

using System;

namespace E4_10
{
    internal class Student
    {
        private string id;
        private string name;
        private decimal score1;
        private decimal score2;
        private decimal score3;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Score1
        {
            get { return score1; }
            set
            {
                if (value >= 0)
                {
                    score1 = value;
                }
            }
        }

        public decimal Score2
        {
            get { return score2; }
            set
            {
                if (value >= 0)
                {
                    score2 = value;
                }
            }
        }

        public decimal Score3
        {
            get { return score3; }
            set
            {
                if (value >= 0)
                {
                    score3 = value;
                }
            }
        }

        public Student(string id, string name, decimal score1, decimal score2, decimal score3) {
            this.id = id;
            this.name = name;
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public decimal GetAggregate()
        {
            return score1 + score2 + score3;
        }

        public decimal GetPersentage()
        {
            decimal maxScore = 50;
            return (GetAggregate() / (3 * maxScore)) * 100;
        }
    }
}
