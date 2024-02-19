using System;

public class Receptions :Event
{
    private string _rsvp;

    public Receptions(string name, string description, string date, string time, string street, string city, string state, string country, string rsvp) : base(name, description, date, time, street, city, state, country)
    {
        _rsvp = rsvp;
        _eventType = "Reception";
    }

    public string FullDetails()
    {
        return $"{_eventType} - " + StandardDetails() + $"\n RSVP: {_rsvp}";
    }
}