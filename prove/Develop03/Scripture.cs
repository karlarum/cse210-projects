using System;
//Adding this for lists
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for(int i = 0 ; i < numberToHide && !IsCompletelyHidden();)
        {
            int randomIndex = random.Next(0, _words.Count);

            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                i++;
            }
        }

        //Hide parts of the reference as well
        _reference.HideReferenceTitle();
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetReference()}";

        foreach (var word in _words)
        {
            displayText += $"{word.GetDisplayText()}";
        }

        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        //this will go through each word in the _words list
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                //if word is not hidden
                return false;
            }
        }
        //if word is hidden
        return true;
    }

}