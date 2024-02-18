using System;

public class Comment
{
    public string _commenter;
    public string _text;


    public string GetFullComment()
    {
        return _commenter + ":" + _text;
    }
}