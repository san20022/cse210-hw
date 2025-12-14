using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // 1 lap = 50 meters = 0.031 miles
        return _laps * 0.031;
    }
}
