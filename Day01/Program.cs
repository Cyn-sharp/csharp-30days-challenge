using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade: ");
        double grade = Convert.ToDouble(Console.ReadLine());

        if (grade >= 90)
            Console.WriteLine("Excellent!");
        else if (grade >= 75)
            Console.WriteLine("Passed!");
        else
            Console.WriteLine("Failed.");
    }
}