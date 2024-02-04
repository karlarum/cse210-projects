using System;

public class StretchingActivity : Activity
{
    public StretchingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Stretch!");
        ShowCountDown(_duration);

        DisplayEndingMessage();
    }
}