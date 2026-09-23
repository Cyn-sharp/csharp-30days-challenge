using System;

class Program
{
    static void Main()
    {
        Console.Write("Create a password: ");
        string password = Console.ReadLine();

        bool hasMinimumLength = password.Length >= 8;
        bool hasNumber = false;

        foreach (char character in password)
        {
            if (char.IsDigit(character))
            {
                hasNumber = true;
                break;
            }
        }

        Console.WriteLine("\n=== PASSWORD CHECK ===");

        if (hasMinimumLength && hasNumber)
        {
            Console.WriteLine("Strong password!");
        }
        else
        {
            Console.WriteLine("Weak password.");

            if (!hasMinimumLength)
                Console.WriteLine("- Must contain at least 8 characters.");

            if (!hasNumber)
                Console.WriteLine("- Must contain at least one number.");
        }
    }
}