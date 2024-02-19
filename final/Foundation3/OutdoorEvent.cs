using System;

public class OutdoorEvent : Event
{
    public string _weatherForecast;

    public OutdoorEvent(string eventTitle, string description, DateTime date, DateTime time, Address address, string weatherForecast)
        : base(eventTitle, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        //Type of event, specific info for that event type - include weather statement
        return base.GetFullDetails() + $"\nThe weather forcast is {_weatherForecast}";
    }

    public override string GetShortDescription()
    {
        //Lists the type of event, title, and the date.
        return $"Outdoor Gathering: {_eventTitle}\nDate: {_date.ToShortDateString()}";
    }
}