using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string nome = GetName();
        float numero = GetNumber();

        DisplayResult(nome, numero);
    }

// Writing Functions
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetName()
    {
        Console.Write("Please enter your name: ");
        string yourName = Console.ReadLine();

        return yourName;
    }

    static float GetNumber()
    {
        Console.Write("Please enter your favorite number: ");
        float yourNumber = float.Parse(Console.ReadLine());

        return yourNumber;
    }

    static float SquareNumber(float numb)
    {
        return numb*numb;
    }

    static void DisplayResult(string name, float numb)
    {
        float sqNumb = SquareNumber(numb);
        Console.WriteLine($"Dear {name}, the square of your number is {sqNumb}");
    }
}