// Creating Resume Class

public class Resume
{
    // Creating class attributes
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Constructor
    public Resume()
    {

    }

    // Display Method
    public void Display()
    {
        Console.WriteLine(_name);
        Console.WriteLine("Jobs:");

        foreach(Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}