using System;

public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(string date, int length, float speed)
        : base(date, length)
    {
        _speed = speed;
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