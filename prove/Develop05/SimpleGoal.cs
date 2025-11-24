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
            return PointsPerEvent;
        }

        public override bool IsComplete() => _isComplete;

        public override string GetDetailsString()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {Name} ({Description}) - Worth {PointsPerEvent} points";
        }

        public override string ToSaveString()
        {

            return $"Simple|{Escape(Name)}|{Escape(Description)}|{PointsPerEvent}|{_isComplete}";
        }


        private static string Escape(string s) => s.Replace("|", "¦");
    }