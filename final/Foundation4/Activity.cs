using System;

public class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual float GetDistance()
    {
        //placeholder
        return 0.0f;
    }

    public virtual float GetSpeed()
    {
        //placeholder
        return 0.0f;
    }

    public virtual float GetPace()
    {
        //placeholder
        return 0.0f;
    }

    public virtual string GetSummary()
    {
        //placeholder
        return "";
    }
}