using System;

public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected DateTime _date;
    protected DateTime _time;
    protected Address _address;

    public Event(string eventTitle, string description, DateTime date, DateTime time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        //Lists title, description, date, time, address
        return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToShortTimeString()}\nAddress: {_address.FormatAddress()}";
    }

    public virtual string GetFullDetails()
    {
        //Type of event, specific info for that event type
         return $"Title: {_eventTitle}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time.ToShortTimeString()}\nAddress: {_address.FormatAddress()}";
    }

    public virtual string GetShortDescription()
    {
        //Lists the type of event, title, and the date.
        return $"Event: {_eventTitle}\nDate: {_date.ToShortDateString()}";
    }
}