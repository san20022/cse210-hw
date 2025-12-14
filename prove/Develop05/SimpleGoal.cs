using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("This goal is already complete. No points awarded.");
            return 0;
        }

        _isComplete = true;
        return GetPointsPerEvent();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return status + " " + GetName() + " (" + GetDescription() + ") - Worth " + GetPointsPerEvent() + " points";
    }

    public override string ToSaveString()
    {
        return "Simple|" + Escape(GetName()) + "|" + Escape(GetDescription()) + "|" + GetPointsPerEvent() + "|" + _isComplete;
    }

    private static string Escape(string s)
    {
        return s.Replace("|", "¦");
    }
}
