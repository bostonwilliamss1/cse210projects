public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;
    public MathAssignment(string student, string topic, string textbook, string problems) : base(student, topic)
    {
       _textBookSection = textbook;
       _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}
