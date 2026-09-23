using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);
        int guess = 0;

        Console.WriteLine("=== NUMBER GUESSING GAME ===");
        Console.WriteLine("Guess a number from 1 to 100.");

        while (guess != secretNumber)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < secretNumber)
                Console.WriteLine("Too low!");
            else if (guess > secretNumber)
                Console.WriteLine("Too high!");
            else
                Console.WriteLine("Correct! 🎉");
        }
    }
}