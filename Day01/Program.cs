using System;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==STUDENT PERFORMANCE ANALYZER==");

            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.Write("Enter course: ");
            string course = Console.ReadLine();

            Console.Write("Enter year level: ");
            string yearLevel = Console.ReadLine();

            Console.Write("Enter Programming grade: ");
            double programmingGrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Math grade: ");
            double mathGrade = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Electronics grade: ");
            double electronicsGrade = Convert.ToDouble(Console.ReadLine());

            double average = (programmingGrade + mathGrade + electronicsGrade) / 3;

            Console.Clear();

            Console.WriteLine("RESULTS:");

            Console.WriteLine("Student: " + studentName);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Year Level: " + yearLevel);
            Console.WriteLine();
            Console.WriteLine("Programming Grade: " + programmingGrade);
            Console.WriteLine("Math Grade: " + mathGrade);
            Console.WriteLine("Electronics Grade: " + electronicsGrade);

            Console.WriteLine("Average Grade: " + average);
            Console.Write("Performance: ");
            if(average >= 90)
            {
                Console.WriteLine("Excellent!");
            } else if(average >= 85)
            {
                Console.WriteLine("Very Good");
            } else if (average >= 75)
            {
                Console.WriteLine("Passed");
            } else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}