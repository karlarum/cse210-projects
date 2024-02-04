using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you? ",
            "Have you ever done anything like this before? ",
            "How did you get started? ",
            "How did you feel when it was complete? ",
            "What made this time different than other times when you were not as successful? ",
            "What is your favorite thing about this experience? ",
            "What could you learn from this experience that applies to other situations? ",
            "What did you learn about yourself through this experience? ",
            "How can you keep this experience in mind in the future? "
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayPrompt();

            foreach (var question in _questions)
            {
                DisplayQuestions();
                Console.WriteLine(question);
                ShowSpinner(3);
                //Pause for three seconds before the next question
                Thread.Sleep(3000);

                if (DateTime.Now >= endTime)
                {
                    break;
                }
            }
        }
        
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string _prompts = GetRandomPrompt();
        Console.WriteLine($"Consider the following prompt: ");
        Console.WriteLine($"--- {_prompts} ---");
        ShowSpinner(3);
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience. ");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(3);
        string _questions = GetRandomQuestion();
        Console.WriteLine($"{_questions}");
        ShowSpinner(5);
    }
}