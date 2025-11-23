using System

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int pointsPerEvent, int targetCount, int targetCount, int bonus)
        : base(name, description, pointsPerEvent)
    {
        _targetCount = Math.Max(1, targetCount);
        _bonus = Math.Max(0, bonus);
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("Checklist already completed. No further points unitl reset.");
            return 0;
        }

        _currentCount++;
        int points = PointsPerEvent;
        if (_currentCount >= _targetCount)
        {

            points += _bonus;
            Console.WriteLine($"Congratulations! You completed the checklist goal and earned a bonus of {_bonus} points!");
        }
        return points;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetDetailsString()
    {
        string status = IsCompleted() ? "[X]" : "[ ]";
        return $"{status} {Name} ({Description}) - Completed {_currentCount}/{_targetCount} - {PointsPerEvent} pts each, { _bonus } bonus at completion";
    }

    public override string ToSaveString()
    {
        return $"Checklist|{Escape(Name)}|{Escape(Description)}|{PointsPerEvent}|{_currentCont}|{_targetCount}|{_bonus}";
    }
    public static ChecklistGoal FromSaved(string name, string desc, int points, int current, int target, int bonus)
    {
        var g = new ChecklistGoal(name, desc, points, target, bonus);
        g._currentCount = Math.Max(0, Math.Min(current, target));
        return g;
    }

    private static string Escape(string s) => s.Replace("|", ";");
}