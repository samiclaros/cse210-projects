public class Video
{
    public string _author;
    public int _duration;
    public string _title;
    public List<Comment> _comments = new();

    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
    }

    public void AddComment(Comment coment)
    {
        _comments.Add(coment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void Display()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Duration: {_duration}");
    }
}