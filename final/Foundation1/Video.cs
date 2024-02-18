using System;
using System.Reflection;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();


    public void AddComment(string commenter, string text)
    {
        _comments.Add(new Comment{_commenter = commenter, _text = text});
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"({_length} seconds)");
        Console.WriteLine($"{GetNumComments()} comments");
        Console.WriteLine($"Comments:");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment.GetFullComment()}");
        }
        Console.WriteLine();
    }
}