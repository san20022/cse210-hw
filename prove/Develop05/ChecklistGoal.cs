using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int pointsPerEvent, int targetCount, int bonus)
        : base(name, description, pointsPerEvent)
    {
        if (targetCount < 1) targetCount = 1;
        if (bonus < 0) bonus = 0;

        _targetCount = targetCount;
        _bonus = bonus;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("Checklist already completed. No further points until reset.");
            return 0;
        }

        _currentCount++;
        int points = GetPointsPerEvent();

        if (_currentCount >= _targetCount)
        {
            points += _bonus;
            Console.WriteLine("Congratulations! You completed the checklist goal and earned a bonus of " + _bonus + " points!");
        }

        return points;
    }

    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return status + " " + GetName() + " (" + GetDescription() + ") - Completed " + _currentCount + "/" + _targetCount + " - " + GetPointsPerEvent() + " pts each, " + _bonus + " bonus at completion";
    }

    public override string ToSaveString()
    {
        return "Checklist|" + Escape(GetName()) + "|" + Escape(GetDescription()) + "|" + GetPointsPerEvent() + "|" + _currentCount + "|" + _targetCount + "|" + _bonus;
    }

    public static ChecklistGoal FromSaved(string name, string desc, int points, int current, int target, int bonus)
    {
        ChecklistGoal g = new ChecklistGoal(name, desc, points, target, bonus);
        if (current < 0) current = 0;
        if (current > target) current = target;
        g._currentCount = current;
        return g;
    }

    private static string Escape(string s)
    {
        return s.Replace("|", "¦");
    }
}
