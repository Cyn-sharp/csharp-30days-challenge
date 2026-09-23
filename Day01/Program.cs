using System;

class Program
{
    static void Main()
    {
        string[] products = { "Keyboard", "Mouse", "Headset" };
        double[] prices = { 850, 450, 1200 };

        double total = 0;

        Console.WriteLine("=== SHOPPING CART ===");

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"{products[i]} - ₱{prices[i]:N2}");
            total += prices[i];
        }

        Console.WriteLine("---------------------");
        Console.WriteLine($"Total: ₱{total:N2}");
    }
}