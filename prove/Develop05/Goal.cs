using System

public abstract class Goal
    {
        private string _name;
        private string _description;
        private int _pointsPerEvent;

        protected Goal(string name, string description, int pointsPerEvent)
        {
            _name = name;
            _description = description;
            _pointsPerEvent = pointsPerEvent;
        }

        public string Name => _name;
        public string Description => _description;
        public int PointsPerEvent => -pointsPerEvent;

        public abstract int RecordEvent();

        public abstract bool IsComplete();

        public virtual string GetDetailsString()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {Name} ({Description})";
        }
        public abstract string ToSaveString();
    }