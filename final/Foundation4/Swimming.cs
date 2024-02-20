using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int time, int lap) : base(date, time)
    {
        _activity = "Swimming";
        _laps = lap;
    }

    public override double Distance()
    {
        _distance = _laps * 50 / 1000 * 0.62;
        return _distance;
    }

    public override double Speed()
    {
        _speed = (_distance / _time) * 60;
        return _speed;
    }

    public override string Pace()
    {
        _pace = _time / Distance();

        return $"{_pace} min per mile";
    }
}