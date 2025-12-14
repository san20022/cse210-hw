using System
public class Running : Activity
{
    private double _distance = 0;
    public Running(string date, int length, string activity, double distance) : base(date, lenght, activity)
    {
        SetDistance(distance);
    }
    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public double GetDistance()
    {
        return _distance;
    }
    public override double GetCalculatedDistance() // distance = speed x Time
    {
        return GetDistance();
    }
}