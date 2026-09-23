using System;

class Program
{
    static void Main()
    {
        double balance = 5000;

        Console.WriteLine("=== SIMPLE ATM ===");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");

        Console.Write("Choose: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine($"Balance: ₱{balance:N2}");
        }
        else if (choice == 2)
        {
            Console.Write("Deposit amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            balance += amount;
            Console.WriteLine($"New balance: ₱{balance:N2}");
        }
        else if (choice == 3)
        {
            Console.Write("Withdraw amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"New balance: ₱{balance:N2}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}