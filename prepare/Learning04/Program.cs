using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment newAssignment = new WritingAssignment("Nathan", "IE", "Book of Mormon");

        Console.WriteLine(newAssignment.GetSummary());
        Console.WriteLine(newAssignment.GetWritingInformation());
    }
}