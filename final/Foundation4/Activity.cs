using System;
public class Activity
{
    private string _date = "01/01/1900";
    private string _activity = "default";
    private int _lengthInMinutes = 0;
    public Activity(string date, int length, string activity)
    {
        SetDate(date);
        SetLength(lenth);
        SetActivity(activity);
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetLength(int length)
    {
        _lengthInMinutes = length;
    }
    public void SetActivity(string activity)
    {
        _activity = activity;
    }
    public string GetDate()
    {
        return_date;
    }
    public int GetLength()
    {
        return _lengthInMinutes;
    }
    public string GetActivity()
    {
        return _activity;
    }
    public virtual double GetCalculatedDistance() // distance = speed (mph) x (time in minutes) / 60
    {
        return GetCalculatedSpeed() * GetLength() / 60;
    }
    public virtual double GetCalculatedSpeed() //miles per hour = distance / time * 60
    {
        return GetCalculatedDistance() / GetLength() * 60;
    }
    public virtual double GetCalculatedPace() //pace = minutes per mile = time / distance
    {
        return GetLength() / GetCalculatedDistance();
    }
    puublic string Summary()
    {
        return $"{GetDate()} {GetActivity()} ({GetLength()} min) - Distance {Math.Round(GetCalculatedDistance(),2)} miles, Speed {Math.Round(GetCalculatedSpeed(),2)} mph, Pace {Math.Round(GetCalculatedPace(),2)} min per mile.";
    }
}