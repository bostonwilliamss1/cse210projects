public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> _comments = new List<Comment>();

    public int CommentTracker()
    {
        return _comments.Count();
    }

    public void DisplayVideos()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (in seconds): {_length}");
        Console.WriteLine($"This video has {CommentTracker()} comments.");
        Console.WriteLine();
        Console.WriteLine("Comments:");
        Console.WriteLine();
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"Comment by {comment._name}: {comment._text}");
        }
        Console.WriteLine();
    }

}
