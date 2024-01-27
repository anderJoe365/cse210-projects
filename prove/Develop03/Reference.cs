using System;
using System.Data;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

     public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string builtReference = "";
        if (_verse == _endVerse)
        {
            builtReference = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            builtReference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
        return builtReference;
    }
}