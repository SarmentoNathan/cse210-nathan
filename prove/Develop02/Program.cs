using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Creating a Journal object
        Journal myJournal = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program!");

        int option = 1;

        while(option != 5)
        {
            Console.WriteLine("Please, select one of the following options\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to");
            option = int.Parse(Console.ReadLine());

            if(option == 1)
            {
                Entry newEntry = new Entry();
                myJournal.AddEntry(newEntry);
            }

            else if(option == 2)
            {
                Console.Clear();
                myJournal.DisplayAll();
            }

            else if(option == 3)
            {
                Console.WriteLine("What is the file name?");
                myJournal.LoadFromFile(Console.ReadLine());
            }

            else if(option == 4)
            {
              Console.WriteLine("What is the file name?");
              myJournal.SaveToFile(Console.ReadLine());
            }

            else if(option == 5)
            {
                Console.WriteLine("Good bye!");
            }

            else
            {
                Console.WriteLine("Invalid option!\n");
            }
        }
    }
}