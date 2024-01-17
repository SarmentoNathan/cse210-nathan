// Creating the Job class

public class Job
{
    // Creating class attributes
    public string _jobTitle;
    public string _company;
    public string _timeInterval;

    // Class constructor
    public Job()
    {

    }

    // Display job method
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_timeInterval}");
    }

}