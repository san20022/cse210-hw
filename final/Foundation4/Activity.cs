using System;

class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    protected int GetLength()
    {
        return _lengthInMinutes;
    }

    protected string GetDate()
    {
        return _date;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public virtual double GetPace()
    {
        return GetLength() / GetDistance();
    }

    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthInMinutes} min) - " +
               $"Distance {Math.Round(GetDistance(), 2)} miles, " +
               $"Speed {Math.Round(GetSpeed(), 2)} mph, " +
               $"Pace {Math.Round(GetPace(), 2)} min per mile";
    }
}
