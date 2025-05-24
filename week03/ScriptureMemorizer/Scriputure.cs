using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWord(int numberToHide)
    {
        Random _random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < numberToHide)
        {
            int radomIndex = _random.Next(_words.Count);
            if (!_words[radomIndex].IsHidden())
            {
                _words[radomIndex].Hide();
                hiddenCount++;
            }
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result;//Trim() 
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}