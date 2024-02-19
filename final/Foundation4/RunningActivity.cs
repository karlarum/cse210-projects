using System;

public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(string date, int length, float distance)
        : base(date, length)
    {
        _distance = distance;
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