using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade in percentage (don't include the % symbol): ");
        int grade = int.Parse(Console.ReadLine()); // Convert the string given by the user into a integer
        
        char letter; // Create the letter variable for the grade

        // Using if else statements to determine the grade letter
        if (grade >= 90)
        {
            // Console.WriteLine("\nYour grade is A"); // Print grade
            letter = 'A';
        }

        else if (grade >= 80)
        {
            // Console.WriteLine("\nYour grade is B"); // Print grade
            letter = 'B';
        }

        else if (grade >= 70)
        {
            // Console.WriteLine("\nYour grade is C"); // Print grade
            letter = 'C';
        }

        else if (grade >= 60)
        {
            // Console.WriteLine("\nYour grade is D"); // Print grade
            letter = 'D';
        }

        else 
        {
            // Console.WriteLine("\nYour grade is F"); // Print grade
            letter = 'F';
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}