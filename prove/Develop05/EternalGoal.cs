using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return GetPointsPerEvent();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return "[∞] " + GetName() + " (" + GetDescription() + ") - " + GetPointsPerEvent() + " pts each time";
    }

    public override string ToSaveString()
    {
        return "Eternal|" + Escape(GetName()) + "|" + Escape(GetDescription()) + "|" + GetPointsPerEvent();
    }

    private static string Escape(string s)
    {
        return s.Replace("|", "￤");
    }
}
