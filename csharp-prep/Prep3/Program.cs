using System;

class Program
{
    static void Main(string[] args)
    {
        /*// Asking for the magic number
        Console.Write("What is the magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());
        */

        // Using Random to determine the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        Console.Write("\nWhat is your guess? ");
        int guess = int.Parse(Console.ReadLine());

        // Using a While Loop to iterate until the magic number is found.
        while (guess != magicNumber)
        {
            if(guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("Lower");
            }

            Console.Write("\nWhat is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You guessed it!");
    }
}