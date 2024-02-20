using System;

public class Cycling : Activity
{


    public Cycling(string date, int time, double speed) : base(date, time)
    {
        _activity = "Cycling";
        _speed = speed;
    }

    public override double Distance()
    {
        _distance = _time * _speed;
        return _distance;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override string Pace()
    {
        _pace = 60 / _speed;

        return $"{_pace} min per mile";
    }
}