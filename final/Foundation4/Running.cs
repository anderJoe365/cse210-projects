using System;

public class Running : Activity
{

    public Running(string date, int time, double distance) : base(date, time)
    {
        _activity = "Running";
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        _speed = _distance / _time * 60;
        return _speed;
    }

    public override string Pace()
    {
        _pace = _time / Distance();

        return $"{_pace} min per mile";
    }
}