using System;

class Program
{
    static void Main()
    {
        Console.Write("Student name: ");
        string name = Console.ReadLine();

        Console.Write("Math grade: ");
        double math = Convert.ToDouble(Console.ReadLine());

        Console.Write("Science grade: ");
        double science = Convert.ToDouble(Console.ReadLine());

        Console.Write("Programming grade: ");
        double programming = Convert.ToDouble(Console.ReadLine());

        double average = (math + science + programming) / 3;

        Console.WriteLine("\n=== RESULT ===");
        Console.WriteLine($"Student: {name}");
        Console.WriteLine($"Average: {average:F2}");

        if (average >= 90)
            Console.WriteLine("Remark: Excellent");
        else if (average >= 75)
            Console.WriteLine("Remark: Passed");
        else
            Console.WriteLine("Remark: Failed");
    }
}