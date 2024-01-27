using System;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
           _reference = reference;

    string [] parts = text.Split(" ");
    foreach(string part in parts)
    {
        _words.Add(new Word(part));
    }  
    }

      public void hideWords(int numberToHide)
    {   Random rand = new Random();
        for (int i = 0; i<numberToHide; i++)
        {
            _words[rand.Next(0,_words.Count)].Hide();
        }
    }

    public string displayAllText()
    {    
        string displayText = "";
        foreach(Word word in _words)
        {   
          displayText = displayText +" "+ word.GetDisplayText();
            
        }
        return displayText;
        }   
        public bool isCompletelyHidden()
        {
           bool allhidden = false;
            foreach (Word w in _words)
            {   
                bool hidden = w.IsHidden();
                if (hidden == false)
                {
                    allhidden =false;
                } 
            }

         return allhidden;
        }
}