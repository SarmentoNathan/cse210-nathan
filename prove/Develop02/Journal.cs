public class Journal
{
    // Adding attributes for this class
    List<Entry> _entries = new List<Entry>();

    // Class Constructor
    public Journal()
    {

    }

    // Adding Methods for this class
    
    // AddEntry Method: creates a new Entry object.
    public void AddEntry(Entry newEntry)
    {
        newEntry.UpdateDate();
        newEntry.UpdatePrompt();
        newEntry.UpdateTextEntry();
        _entries.Add(newEntry); // Add the updated newEntry object to the list of entries
    }

    // DisplayAll Method: Display all Entries stored in _entries attribute
    public void DisplayAll()
    {
        foreach(Entry entradas in _entries)
        {
            entradas.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using(StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach(Entry entradas in _entries)
                    {
                        string message = entradas._date + "|" + entradas._promptText + "|" + entradas._entryText;
                        outputFile.WriteLine(message);
                    }
                    
                }
    }

    public void LoadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines)
        {
            string[] parts = line.Split("|");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            _entries.Add(newEntry);
        }
    }
}