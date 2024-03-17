using System;

namespace E4_10
{
    class StudentTest
    {
        static void Main()
        {
            Student student = new Student("2022481031", "Efe Can Kara", 35, 45, 90);

            Console.WriteLine("Student Id: " + student.Id);
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Score 1: " + student.Score1);
            Console.WriteLine("Score 2: " + student.Score2);
            Console.WriteLine("Score 3: " + student.Score3);
            Console.WriteLine("Aggregate Marks: " + student.GetAggregate());
            Console.WriteLine("Percentage: " + student.GetPersentage());
        }
    }
}