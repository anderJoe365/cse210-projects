using System;

public class Event
{
    protected string _eventName;
    protected string _date;
    protected string _eventType;

    private string _description;
    private string _time;
    private Address _address;

    public Event(string name, string description, string date, string time, string street, string city, string state, string country)
    {
        _eventType = "Event";
        _eventName = name;
        _description = description;
        _date = date;
        _time = time;
        _address = new Address(street, city, state, country);
    }

    public  string StandardDetails()
    {
        return $"{_eventName} - {_description} \n Address: {_address.GetAddress()} \n {_date} - {_time}";

    }

    public string ShortDescription()
    {
        return $"{_eventType} - {_eventName} - {_date}";
    }
}