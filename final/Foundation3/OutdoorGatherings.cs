using System;

public class OutdoorGatherings : Event
{
    private string _weather;

    public OutdoorGatherings(string name, string description, string date, string time, string street, string city, string state, string country, string weather) : base(name, description, date, time, street, city, state, country)
    {
        _weather = weather;
        _eventType = "Outdoor Gathering";
    }

    public string FullDetails()
    {
        return $"{_eventType}" + StandardDetails() + $"\n Weather: {_weather}";
    }
}