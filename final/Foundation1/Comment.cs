public class Comment
{
    private string _personName;

    private string _comment;

    public Comment(string personName, string comment)
    {
        _personName = personName;
        _comment = comment;
    }

    public string GetComment()
    {
        return $"{_personName}: {_comment}";
    }
}