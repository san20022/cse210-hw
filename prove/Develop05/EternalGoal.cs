using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return PointsPerEvent;
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[∞] {Name} ({Description}) - {PointsPerEvent} pts each time";
    }

    public override string ToSaveString()
    {

        return $"Eternal|{Escape(Name)}|{Escape(Description)}|{PointsPerEvent}";
    }

    private static string Escape(string s) => s.Replace("|", "￤");
}