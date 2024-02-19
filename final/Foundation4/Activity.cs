using System;

public class Activity
{
    protected DateTime _date;
    protected int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        //track length in minutes
        _length = length;
    }

    public virtual float GetDistance()
    {
        return 0.0f;
    }

    public virtual float GetSpeed()
    {
        return 0.0f;
    }

    public virtual float GetPace()
    {
        return 0.0f;
    }

    public virtual string GetSummary()
    {
        //Example: 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{_date.ToShortDateString()} Activity ({_length})- {GetDistance()} {GetSpeed()} {GetPace()}";
    }
}