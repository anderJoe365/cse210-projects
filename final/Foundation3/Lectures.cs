using System;
using System.Reflection;

public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string name, string description, string date, string time, string street, string city, string state, string country, string speaker, int capacity) : base(name, description, date, time, street, city, state, country)
    {
        _speaker = speaker;
        _eventType = "Lecture";
        _capacity = capacity;
    }

    public string FullDetails()
    {
        return $"{_eventType} - " + StandardDetails() + $"\n Speaker: {_speaker} - Capacity: {_capacity}";
    }
}