using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        //placeholder
        return 0.0f;
    }

    public override float GetSpeed()
    {
        //placeholder
        return 0.0f;
    }

    public override float GetPace()
    {
        //placeholder
        return 0.0f;
    }

    public override string GetSummary()
    {
        //placeholder
        return "";
    }
}