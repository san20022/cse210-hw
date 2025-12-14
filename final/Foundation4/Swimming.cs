using System;
public class Swimming : Activity
{
    private int _laps = 0;
    public Swimming(string date, int length, string activity, int laps) : base(date, length, activity)
    {
        SetLaps(laps);
    }
    public void SetLaps(int laps)
    {
        _laps = laps;
    }
    public int GetLaps()
    {
        return _laps;
    }
    public override double GetCalculatedDistance() //swimming laps * 50 / 1000 * 0.62
    {
        //1 lap is 50 meters, which is 0.0310686 miles
        return GetLaps() * 0.0310686
    }
}