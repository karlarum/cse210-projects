using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public List<string> _prompts = new List<string>();

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine($"Date: {dateText} - Prompts: ");

        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }

        Console.WriteLine($"Entry: {_entryText}");
    }
}