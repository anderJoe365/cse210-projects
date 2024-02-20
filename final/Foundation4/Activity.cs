using System;

public abstract class Activity
{
    private string _date;

    protected int _time;
    protected string _activity;

    protected double _distance;
    protected double _speed;
    protected double _pace;

    public Activity(string date, int time)
    {
        _date = date;
        _time = time;
    }

    public abstract double Distance();
    
    public abstract double Speed();

    public abstract string Pace();

    public string Summary()
    {
        return $"{_date} {_activity} ({_time} min) - Distance {_distance} miles, Speed {_speed} mph, Pace: {Pace()}";
    }
}