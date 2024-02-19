using System;

public class LectureEvent : Event
{
    private string _speakerName;
    private int _capacity;

    public LectureEvent(string eventTitle, string description, DateTime date, DateTime time, Address address, string speakerName, int capacity)
        : base(eventTitle, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        //Type of event, specific info for that event type - include speaker name & capacity
        return base.GetFullDetails() + $"\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }

    public override string GetShortDescription()
    {
        //Lists the type of event, title, and the date.
        return $"Lecture: {_eventTitle}\nDate: {_date.ToShortDateString()}";
    }
}