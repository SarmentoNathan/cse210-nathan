public class WritingAssignment : Assignment
{
    /*Class Attributes*/
    private string _title = "";

    /*Class Constructor*/
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    /*Class Methods*/
    public string GetWritingInformation()
    {
        return _title + " by " + GetStudentName();
    }
}