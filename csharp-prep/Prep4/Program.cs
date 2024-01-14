using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating the list to be used
        List<int> numbers = new List<int>();

        // New number variable
        int newNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter Number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        } while(newNumber != 0);

        int soma = numbers.Sum();
        double media = numbers.Average();
        int maximo = numbers.Max();

        Console.WriteLine($"The Sum is: {soma}\nThe average is: {media}\nThe largest number is: {maximo}");
    }
}