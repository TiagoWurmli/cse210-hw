public class Comment
{
    private string _text;
    private string _commentator;

    public Comment(string text, string commentator)
    {
        _text = text;
        _commentator = commentator;
    }

    public string GetCommentText()
    {
        return _text;
    }
    public string GetCommentator()
    {
        return _commentator;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_text} - {_commentator}");
    }
}