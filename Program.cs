using System;

namespace MyDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("Guess number between 1 and 100.");
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                Console.Write("Enter your number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int guess))
                {
                    attempts++;

                    if (guess == secretNumber)
                    {
                        guessedCorrectly = true;
                        Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    }
                    else if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try a higher number.");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try a lower number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}
