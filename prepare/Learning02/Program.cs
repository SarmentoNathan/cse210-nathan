using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an object from Job class
        Job job1 = new Job();

        // Changing the attributes of this object
        job1._jobTitle = "Professor";
        job1._company = "Uniesp Centro Universitário";
        job1._timeInterval = "2016-2023";

        // Showing the information of the attributes
        Console.WriteLine($"{job1._jobTitle} ({job1._company}) {job1._timeInterval}");
    }
}