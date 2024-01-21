using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What is something I am grateful for today? ",
        "What did I learn today?",
        "What made me smile today? "

    };

    private int _lastDisplayedIndex = -1;

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index;

        do
        {
            index = random.Next(_prompts.Count);
        } while (index == _lastDisplayedIndex);

        _lastDisplayedIndex = index;
        Console.WriteLine($"Prompt: {_prompts[index]}");
        return _prompts[index];
    }

    public void Display()
    {
        Console.WriteLine($"Prompt: ");

        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }
}