using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string First_Name = Console.ReadLine();
        Console.Write("What is your last name?");
        string Last_Name = Console.ReadLine();

        Console.WriteLine($"\n\nYour name is {Last_Name}, {Last_Name} {First_Name}.");
    }
}