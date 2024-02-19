using System;

public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(DateTime date, int length, float speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * _length / 60f;
    }

    public override float GetSpeed()
    {
        return _speed;
    }

    public override float GetPace()
    {
        return 60f / _speed;
    }
    
    public override string GetSummary()
    {
        //Example: 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        return $"{_date.ToShortDateString()} Cycling ({_length} min)- Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}