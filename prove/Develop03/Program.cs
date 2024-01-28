using System;

class Program
{
    static void Main(string[] args)
    {
        /*EXCEEDING THE REQUIREMENTS - Sorting a scripture and determining the Reference*/
        BookOfMormonScriptures sortedScripture = new BookOfMormonScriptures();
        string rndScrip = sortedScripture.GetRandomScripture();
        sortedScripture.SetReference(rndScrip);

        // Creating a Reference object with the sorted scripture
        Reference newRef = new Reference(sortedScripture.GetBook(), sortedScripture.GetChapter(), sortedScripture.GetVerse(), sortedScripture.GetEndVerse());
        
        // Creating a Scripture object
        Scripture newScripture = new Scripture(newRef, rndScrip);

        // Auxiliary variables
        int shownQtt;
        int hideNumb;
        string answer = "";
        Random rnd = new Random();

        bool flag = !newScripture.IsCompletelyHidden();
        while(flag)
        {
            Console.WriteLine(newRef.GetDisplayText() + " " + newScripture.GetDisplayText());
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            answer = Console.ReadLine();

            if(answer == "quit")
            {
                flag = false;
            }

            else
            {
                shownQtt = newScripture.shownQuantity();
                if(shownQtt >= 10)
                {
                    hideNumb = rnd.Next(10);
                    newScripture.HideRandomWords(hideNumb);
                }
                else
                {
                    hideNumb = rnd.Next(shownQtt);
                    newScripture.HideRandomWords(hideNumb);
                }

                Console.Clear();
                flag = !newScripture.IsCompletelyHidden();

                if(!flag)
                {
                    Console.WriteLine(newRef.GetDisplayText() + " " + newScripture.GetDisplayText());
                    Console.Write("\nPress enter to continue or type 'quit' to finish: ");
                    answer = Console.ReadLine();
                }  
            }

        }

    }
}