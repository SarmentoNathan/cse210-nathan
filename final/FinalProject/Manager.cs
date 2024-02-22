using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

public class Manager
{
    /*Class attributes*/
    private Bride _bride;
    private Groom _groom;
    private List<Guest> _guests = new List<Guest>();
    private List<SpecialGuest> _specialGuests = new List<SpecialGuest>();
    private List<Supplier> _supplierList = new List<Supplier>();


    /*Class Constructor*/
    public Manager()
    {
        
    }

    /*Class Methods*/
    public void Start()
    {
        bool flag = true;
        string answer = "";

        Console.Clear();
        Console.WriteLine("Welcome to the wedding planner!");

        while(flag)
        {    
            Console.WriteLine("Menu options:\n\t1.Register Groom and Bride\n\t2.Show Couple Info\n\t3.Register Guest\n\t4.Show Guest List\n\t5.Register Special Guest\n\t6.Show Special Guest List\n\t7.Register Supplier\n\t8.Show Supplier Info\n\t9.Show total wedding charge\n\t10.Confirm Guests Presence\n\t11.Quit");
            answer = Console.ReadLine();

            switch(answer)
            {
                case "1":
                    RegisterCouple();
                    break;
                
                case "2":
                    ShowCoupleInfo();
                    break;
                
                case "3":
                    RegisterGuest();
                    break;
                
                case "4":
                    ShowGuestList();
                    break;
                
                case "5":
                    RegisterSpecialGuest();
                    break;
                
                case "6":
                    ShowSpecialGuestList();
                    break;
                
                case "7":
                    RegisterSupplier();
                    break;
                
                case "8":
                    ShowSupplierSummary();
                    break;
                
                case "9":
                    CalculateTotalCharge();
                    break;

                case "10":
                    ConfirmPresence();
                    break;

                case "11":
                    flag = false;
                    break;
                
                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }
    }

    public void RegisterCouple()
    {
        string brideName;
        string groomName;
        int brideAge;
        int groomAge;
        string bridePhone;
        string groomPhone;

        Console.WriteLine("Let's register our Bride info!");

        Console.Write("Our little bride name: ");
        brideName = Console.ReadLine();
        Console.Write("Our little bride age: ");
        brideAge = int.Parse(Console.ReadLine());
        Console.Write("Our little bride phone: ");
        bridePhone = Console.ReadLine();

        _bride = new Bride(brideName, brideAge, bridePhone);

        Console.WriteLine("\nBride Registered!");

        Thread.Sleep(1000);

        Console.Clear();

        Console.WriteLine("Let's register our Groom info!");

        Console.Write("Our groom name: ");
        groomName = Console.ReadLine();
        Console.Write("Our groom age: ");
        groomAge = int.Parse(Console.ReadLine());
        Console.Write("Our groom phone: ");
        groomPhone = Console.ReadLine();

        _groom = new Groom(groomName, groomAge, groomPhone);

        Console.WriteLine("\nGroom Registered!");

        Thread.Sleep(1000);

        Console.Clear();
    }

    public void ShowCoupleInfo()
    {
        Console.WriteLine($"{_bride.GetFirstName()} and {_groom.GetFirstName()} wedding!\n");
        Console.WriteLine($"Bride info:\nName: {_bride.GetName()}\nAge: {_bride.GetAge()}\nPhone: {_bride.GetPhone()}\n");
        Console.WriteLine($"Groom info:\nName: {_groom.GetName()}\nAge: {_groom.GetAge()}\nPhone: {_groom.GetPhone()}");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

    public void RegisterGuest()
    {
        string guestName;
        string guestPhone;

        Console.Write("Guest's name: ");
        guestName = Console.ReadLine();
        Console.Write("Guest's phone: ");
        guestPhone = Console.ReadLine();

        Guest newGuest = new Guest(guestName, guestPhone);
        _guests.Add(newGuest);

        Console.WriteLine("Guest Registered!");
        Thread.Sleep(1000);

        Console.Clear();
    }

    public void ShowGuestList()
    {
        foreach(Guest conv in _guests)
        {
            Console.WriteLine($"{conv.GetName()} - {conv.GetPhone()}");
        }
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();
    }

public void RegisterSpecialGuest()
    {
        string guestName;
        string guestPhone;
        string function = "";

        Console.Write("Guest's name: ");
        guestName = Console.ReadLine();
        Console.Write("Guest's phone: ");
        guestPhone = Console.ReadLine();

        bool flag = true;
        string option;
        while(flag)
        {
            Console.WriteLine("Choose the function of this special guest:\n\t1-Bride's mother\n\t2-Bride's father\n\t3-Groom's mother\n\t4-Groom's father\n\t5-Best man\n\t6-Maid of honour\n\t7-Demoiselle\n\t8-Child court\n\t9-Celebrant");
            option = Console.ReadLine();
            switch(option)
            {
                case "1":
                    function = "Bride's mother";
                    flag = false;
                    break;
                case "2":
                    function = "Bride's father";
                    flag = false;
                    break;
                case "3":
                    function = "Groom's mother";
                    flag = false;
                    break;
                case "4":
                    function = "Groom's father";
                    flag = false;
                    break;
                case "5":
                    function = "Best man";
                    flag = false;
                    break;
                case "6":
                    function = "Maid of Honour";
                    flag = false;
                    break;
                case "7":
                    function = "Demoiselle";
                    flag = false;
                    break;
                case "8":
                    function = "Child court";
                    flag = false;
                    break;
                case "9":
                    function = "Celebrant";
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }

        SpecialGuest newGuest = new SpecialGuest(guestName, guestPhone, function);

        flag = true;
        while(flag)
        {
            Console.Write("Do you want to delegate some special task to this guest (y/n)? ");
            option = Console.ReadLine();

            switch(option.ToLower())
            {
                case "y":
                    newGuest.DelegateTask();
                    flag = false;
                    break;
                case "n":
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        }

        _specialGuests.Add(newGuest);

        Console.WriteLine("Special Guest Registered!");
        Thread.Sleep(1000);

        Console.Clear();
    }

public void ShowSpecialGuestList()
    {
        foreach(SpecialGuest conv in _specialGuests)
        {
            Console.WriteLine($"{conv.GetName()} - {conv.GetFunction()} - {conv.GetPhone()}");
            Console.WriteLine($"Task designed: {conv.GetTask()}\n");
        }
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
        Console.Clear();
    }

public void RegisterSupplier()
{
    bool flag = true;
    string option;
    string companyName = "";

    while(flag)
    {
        Console.WriteLine("Please, select the type of service to be offered:\n\t1-Food\n\t2-Music\n\t3-Decoration");
        option = Console.ReadLine();

        switch(option)
        {
            case "1":
                
                Console.Write("Enter the name of the food supplier company: ");
                companyName = Console.ReadLine();

                FoodSupplier newFoodCompany = new FoodSupplier(companyName);

                float valueCharge;
                Console.Clear();
                Console.Write("Enter the requested charge per guest: ");
                valueCharge = float.Parse(Console.ReadLine());
                newFoodCompany.SetValue(valueCharge);
                
                int totalGuests = _guests.Count + _specialGuests.Count;
                newFoodCompany.SetNumberOfGuests(totalGuests);
                newFoodCompany.CalculateFee();

                Console.Clear();
                bool flag2 = true;
                string menuOption;
                string newMenuItem;
                Console.WriteLine("Add some items for your menu!");
                while(flag2)
                {
                    Console.WriteLine("\t1.Add item\n\t2.Quit");
                    menuOption = Console.ReadLine();

                    switch(menuOption)
                    {
                        case "1":
                            Console.Write("What food do you want to add? ");
                            newMenuItem = Console.ReadLine();
                            newFoodCompany.AddMenu(newMenuItem);
                            break;
                        case "2":
                            flag2 = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                }

                Console.Clear();

                Console.WriteLine($"Food Supplier Summary:\nCompany Name: {newFoodCompany.GetName()}\nCharge: R${newFoodCompany.GetFee()}");
                Console.WriteLine("Menu:");
                newFoodCompany.PrintMenu();
                
                _supplierList.Add(newFoodCompany);
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();

                flag = false;
                break;

            case "2":
                Console.Clear();
                Console.Write("Enter the name of the music supplier company: ");
                companyName = Console.ReadLine();

                MusicSupplier newMusicCompany = new MusicSupplier(companyName);

                Console.Clear();
                newMusicCompany.CalculateFee();

                Console.Clear();
                bool flag3 = true;
                string musicOption;
                string newMusicItem;
                Console.WriteLine("Add some musics to your list!");
                while(flag3)
                {
                    Console.WriteLine("\t1.Add music\n\t2.Quit");
                    musicOption = Console.ReadLine();

                    switch(musicOption)
                    {
                        case "1":
                            Console.Write("What music do you want to add? ");
                            newMusicItem = Console.ReadLine();
                            newMusicCompany.AddMusic(newMusicItem);
                            break;
                        case "2":
                            flag3 = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                }

                Console.Clear();

                Console.WriteLine($"Music Supplier Summary:\nCompany Name: {newMusicCompany.GetName()}\nCharge: R${newMusicCompany.GetFee()}");
                Console.WriteLine("Music list:");
                newMusicCompany.PrintMusicList();

                _supplierList.Add(newMusicCompany);
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();

                flag = false;
                break;

            case "3":
                Console.Clear();
                Console.Write("Enter the name of the decoration supplier company: ");
                companyName = Console.ReadLine();

                DecorationSupplier newDecorationCompany = new DecorationSupplier(companyName);

                newDecorationCompany.AddItem();
                newDecorationCompany.CalculateFee();

                Console.Clear();
                bool flag4 = true;
                string decorationOption;
                string newDecorationItem;
                Console.WriteLine("Choose the colors of your wedding!");
                while(flag4)
                {
                    Console.WriteLine("\t1.Add color\n\t2.Quit");
                    decorationOption = Console.ReadLine();

                    switch(decorationOption)
                    {
                        case "1":
                            Console.Write("Choose a color for your wedding: ");
                            newDecorationItem = Console.ReadLine();
                            newDecorationCompany.AddColor(newDecorationItem);
                            break;
                        case "2":
                            flag4 = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                }

                Console.Clear();

                Console.WriteLine($"Decoration Supplier Summary:\nCompany Name: {newDecorationCompany.GetName()}\nCharge: R${newDecorationCompany.GetFee()}");
                newDecorationCompany.GetDecorationInfo();

                _supplierList.Add(newDecorationCompany);
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();

                flag = false;
                break;

            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
}

public void ShowSupplierSummary()
{
    Console.WriteLine("Wedding Suppliers:\n");

    foreach(Supplier comp in _supplierList)
    {
        Console.WriteLine($"Supplier: {comp.GetName()} - Charge: R${comp.GetFee()}");
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}

public void CalculateTotalCharge()
{
    float totalCharge = 0;

    foreach(Supplier comp in _supplierList)
    {
        totalCharge += comp.GetFee();
    }

    Console.WriteLine($"The total amount to be paid for your wedding is R${totalCharge}");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

public void ConfirmPresence()
{
    Console.WriteLine("Your guest list:");
    ShowGuestList();

    Console.WriteLine("After calling to each guest in the list, confirm the presence of each one of them to the wedding.");
    Thread.Sleep(3000);

    foreach(Guest person in _guests)
    {
        Console.Clear();
        Console.WriteLine($"Guest: {person.GetName()}");
        person.ConfirmPresence();
        Console.WriteLine("\nPresence registered!");
        Thread.Sleep(2000);
    }

    Console.Clear();
    Console.WriteLine("Confirmed guests:");
    foreach(Guest person in _guests)
    {
        if(person.GetPresence())
        {
            Console.WriteLine($"{person.GetName()} - {person.GetPhone()}");
        }
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}

}