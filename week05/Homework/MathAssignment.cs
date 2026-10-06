public class MathAssignment : Assignment
{
    private string _texbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string texbookSection, string problems ) : base(studentName, topic)
    {
        _texbookSection = texbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_texbookSection} Problems {_problems}";
    }
}