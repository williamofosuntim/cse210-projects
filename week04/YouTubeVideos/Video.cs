using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        System.Console.WriteLine($"Title: {_title}");
        System.Console.WriteLine($"Author: {_author}");
        System.Console.WriteLine($"Length: {_length} seconds");
        System.Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        System.Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            System.Console.WriteLine($"- {comment.GetDisplayText()}");
        }
        System.Console.WriteLine();
    }
}