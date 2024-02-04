using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now <= endTime)

        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);

            if (DateTime.Now > endTime)
                break;

            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }

        DisplayEndingMessage();
    }
}