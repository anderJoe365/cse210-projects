using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        string replace = "";
        if (_isHidden == true)
        {
           
            for (int i = 0; i < _text.Length; i++)
            {
                replace = replace + "_";
            }
            return replace;
        }
        else
        {
            return _text;
        }
    
    }

}