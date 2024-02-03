public class Assignment
{
    /* Class attributes */
    private string _studentName = "";
    private string _topic = "";

    /* Class Constructor */
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    /* Class Methods */
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }
}