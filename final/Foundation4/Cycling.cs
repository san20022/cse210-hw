using System;
public class Cycling : Activity
{
    private double _speed = 0;
    public Cycling(string date, int length, string activity, double speed) : base(date, length, activity)
    {
        SetSpeed(speed);
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    public double GetSpeed()
    {
        return _speed;
    }
    public override double GetCalculatedSpeed() //distance = speed x time
    {
        return GetSpeed();
    }
}