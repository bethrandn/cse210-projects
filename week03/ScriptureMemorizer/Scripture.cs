using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(" ");
        foreach (string w in words)
        {
            _words.Add(new Word(w));
        }
    }
    
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<int> availableIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                availableIndexes.Add(i);
            }
        }


        for (int i = 0; i < numberToHide && availableIndexes.Count > 0; i++)
        {
            int randomPosition = random.Next(availableIndexes.Count);

            int wordIndex = availableIndexes[randomPosition];

            _words[wordIndex].Hide();

            availableIndexes.RemoveAt(randomPosition);
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText();

        result += " ";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result;
            
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