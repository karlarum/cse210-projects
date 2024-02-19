using System;

public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(DateTime date, int length, float distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        return _distance / _length * 60f;
    }

    public override float GetPace()
    {
        return _length / _distance;
    }

    public override string GetSummary()
    {
        //Example: 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{_date.ToShortDateString()} Running ({_length} min)- Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}