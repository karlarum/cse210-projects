using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count)
        : base(name, description, duration)
    {
        _count = count;
        _prompts = new List<string>
        {
            "Who are people that you appreciate? ",
            "What are personal strengths of yours? ",
            "Who are people that you have helped this week? ",
            "When have you felt the Holy Ghost this month? ",
            "Who are some of your personal heroes? "
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        GetListFromUser();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userResponse = new List<string>();

        string _prompts = GetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"---{_prompts}---");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now <= endTime)
        {
            string response = Console.ReadLine();
            userResponse.Add(response);
        }

        _count = userResponse.Count;
        Console.WriteLine($"You listed {_count} items!");

        return userResponse;
    }
}