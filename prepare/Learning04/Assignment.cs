public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }

    public string getSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}