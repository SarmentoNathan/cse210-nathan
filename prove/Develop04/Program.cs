using System;

class Program
{
    static void Main(string[] args)
    {
        bool flag = true;

        while(flag)
        {
            Console.Clear();
            Console.WriteLine("Menu options:\n\t1. Start Breathing Activity\n\t2. Start Reflecting Activity\n\t3. Start Listing Activity\n\t4. Quit");
            Console.Write("Select a choice from the menu: ");

            string option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    BreathingActivity breathBreak = new BreathingActivity();
                    breathBreak.Run();
                    break;
                case "2":
                    ReflectingActivity reflectBreak = new ReflectingActivity();
                    reflectBreak.Run();
                    break;
                case "3":
                    ListingActivity listingBreak = new ListingActivity();
                    listingBreak.Run();
                    break;
                case "4":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }

        
    }
}