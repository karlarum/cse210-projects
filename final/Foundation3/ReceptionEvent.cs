using System;

public class ReceptionEvent : Event
{
    private string _rsvp;

    public ReceptionEvent(string eventTitle, string description, DateTime date, DateTime time, Address address, string rsvp)
        : base(eventTitle, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public string EmailForRSVP()
    {
        return $"Please RSVP by responding to {_rsvp} one week before the event.";
    }

    public override string GetFullDetails()
    {
        //Type of event, specific info for that event type - include email for RSVP
        return base.GetFullDetails() + $"\n{EmailForRSVP()}";
    }

    public override string GetShortDescription()
    {
        //Lists the type of event, title, and the date.
        return $"Reception: {_eventTitle}\nDate: {_date.ToShortDateString()}";
    }
}