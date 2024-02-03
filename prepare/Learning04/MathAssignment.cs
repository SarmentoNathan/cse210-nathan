public class MathAssignment : Assignment
{
    /*Class Attributes*/
    private string _textbookSection = "";
    private string _problems = "";

    /*Class Constructor*/
    public MathAssignment(string studentName, string topic, string section, string problems) : base(studentName, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    /*Class Methods*/
    public string GetHomeworkList()
    {
        return "Section " + _textbookSection + " Problems " + _problems;
    }
}