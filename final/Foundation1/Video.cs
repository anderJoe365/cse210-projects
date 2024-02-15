using System;

public class Video
{

    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comment;
    private int _commentCount;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

        _comment = new List<Comments>();
    }   

    public void AddComment(string userName, string text)
    {
        Comments comment = new Comments(userName, text);

        _comment.Add(comment);
    }

    public int CommentCount()
    {
        _commentCount = _comment.Count();

        return _commentCount;

    }

    public void DesplayComments()
    {
        foreach(Comments comment in _comment)
        {
            comment.DisplayComment();
        }
    }

    public string VideoInformation()
    {
        string VideoInfo = $"{_title} created by {_author}. \n {_length} seconds";
        return VideoInfo;
    }
}