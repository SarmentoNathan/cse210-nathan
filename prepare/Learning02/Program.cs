using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an object from Job class
        Job job1 = new Job();

        // Changing the attributes of this object
        job1._jobTitle = "Professor";
        job1._company = "Uniesp University Centre";
        job1._timeInterval = "2016-2023";

        // Showing the information of the attributes
        job1.DisplayJobDetails();

        // Repeating the procedure to another job
        Job job2 = new Job();

        job2._jobTitle = "Substitute Professor";
        job2._company = "Federal Institute of Pernambuco";
        job2._timeInterval = "2021-2023";

        job2.DisplayJobDetails();

    }
}