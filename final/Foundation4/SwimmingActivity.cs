using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * 50f / 1000f * 0.62f;
    }

    public override float GetSpeed()
    {
        return GetDistance() / _length * 60f;
    }

    public override float GetPace()
    {
        return _length / GetDistance();
    }

    public override string GetSummary()
    {
        //Example: 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{_date.ToShortDateString()} Swimming ({_length} min)- Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} min per mile, Pace: {GetPace():F2} min per mile";
    }
}