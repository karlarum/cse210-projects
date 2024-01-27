using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        //this will make sure a scripture with only one verse will not display "Revelation 1:3-0" 
        //but "Revelation 1:3" instead)
        if (_verse == _endVerse || _endVerse == 0)
            //this is for a single verse (ex John 3:16)
            return $"{_book} {_chapter} : {_verse}";
        else 
            //this is for a range of verses (ex John 3:16-17)
            return $"{_book} {_chapter} : {_verse}-{_endVerse}";
    }

    public string GetDisplayText()
    {
        return GetReference();
    }

    public void HideBook()
    {
        _book = "____";
    }

    public void HideReferenceTitle()
    {
        Random random = new Random();
        int randomPart;

        if (_endVerse == 0 || _endVerse == _verse)
        {
            randomPart = random.Next(0, 3);
        }
        else
        {
            randomPart = random.Next(0, 4);
        }
        switch (randomPart)
        {
            case 0:
                _book = "____";
                break;
            case 1:
                _chapter = 0;
                break;
            case 2:
                _verse = 0;
                break;
            case 3:
                _endVerse = 0;
                break;
        }
    }
}