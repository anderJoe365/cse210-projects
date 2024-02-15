using System;

public class Comments
{
    private string _user;
    private string _text;

    public Comments(string user, string text)
    {
        _user = user;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_user}: {_text}");
    }
}