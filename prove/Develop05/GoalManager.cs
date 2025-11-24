using System;


public class GoalManager
    {
        private List<Goal> _goals = new();
        private int _score = 0;
        private HashSet<string> _badges = new();


        public int Level => (_score / 1000) + 1;


        public void AddGoal(Goal g) => _goals.Add(g);

        public void ShowGoals()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals created yet.");
                return;
            }

            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        public void ShowScore()
        {
            Console.WriteLine($"Score: {_score} | Level: {Level}");
            if (_badges.Count > 0)
            {
                Console.WriteLine("Badges: " + string.Join(", ", _badges));
            }
        }


        public void RecordEvent(int goalIndex)
        {
            if (goalIndex < 1 || goalIndex > _goals.Count)
            {
                Console.WriteLine("Invalid goal selection.");
                return;
            }

            var goal = _goals[goalIndex - 1];
            int gained = goal.RecordEvent();
            if (gained > 0)
            {
                _score += gained;
                Console.WriteLine($"You gained {gained} points! New score: {_score}");
                CheckForBadges();
            }
            else
            {
                Console.WriteLine("No points gained from that event.");
            }
        }


        public void Save(string path)
        {
            using var writer = new StreamWriter(path);

            writer.WriteLine(_score);

            writer.WriteLine(string.Join(",", _badges));

            foreach (var g in _goals)
            {
                writer.WriteLine(g.ToSaveString());
            }
            Console.WriteLine($"Saved { _goals.Count } goals to {path} (score {_score}).");
        }


        public void Load(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Save file not found.");
                return;
            }

            var loadedGoals = new List<Goal>();
            int loadedScore = 0;
            var loadedBadges = new HashSet<string>();

            var lines = File.ReadAllLines(path);
            if (lines.Length >= 1)
            {

                int.TryParse(lines[0], out loadedScore);
            }
            if (lines.Length >= 2)
            {
                var badgeLine = lines [1];
                if (!string.IsNullOrWhiteSpace(badgeLine))
                {
                    var badges = badgeLine.Split(',', StringSplitOptions.RemoveEmptyEntries);
                    foreach (var b in badges) loadedBadges.Add(b.Trim());
                }
            }

            for (int i = 2; i < lines.Length; i++)
            {
                string line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split('|');
                string type = parts [0];
                try
                {
                    if (type == "Simple")
                    {

                        string name = Unescape(parts[1]);
                        string desc = Unescape(parts[2]);
                        int pts = int.Parse(parts[3]);
                        bool complete = bool.Parse(parts[4]);
                        var g = new SimpleGoal(name, desc, pts);

                        if (complete)
                        {
                            g.RecordEvent();
                        }
                        loadedGoals.Add(g);
                    }
                    else if (type == "Eternal")
                    {

                        string name = Unescape(parts[1]);
                        string desc = Unescape(parts[2]);
                        int pts = int.Parse(parts[3]);
                        loadedGoals.Add(new EternalGoal(name, desc, pts));
                    }
                    else if (type == "Checklist")
                    {

                        string name = Unescape(parts[1]);
                        string desc = Unescape(parts[2]);
                        int pts = int.Parse(parts[3]);
                        int current = int.Parse(parts[4]);
                        int target = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);
                        loadedGoals.Add(ChecklistGoal.FromSaved(name, desc, pts, current, target, bonus));
                    }
                    else
                    {
                        Console.WriteLine($"Unknown goal type in save: {type}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to parse line: {line} ({ex.Message})");
                }
            }

            _goals = loadedGoals;
            _score = loadedScore;
            _badges = loadedBadges;
            Console.WriteLine($"Loaded { _goals.Count } goals. Score: {_score}. Badges: ...");
        }

        private static string Unescape(string s) => s.Replace("¦", "|");


        private void CheckForBadges()
        {
            var milestones = new Dictionary<int, string>
            {
                {1000, "1000-Point Achiever"},
                {2500, "Quarter-Master"},
                {5000, "Legendary Questor"}
            };

            foreach (var kv in milestones)
            {
                if (_score >= kv.Key && !_badges.Contains(kv.Value))
                {
                    _badges.Add(kv.Value);
                    Console.WriteLine($"Badge earned: {kv.Value } (for reaching {kv.Key} points)!");
                }
            }
        }


        public static void PrintGoalTypes()
        {
            Console.WriteLine("Types:");
            Console.WriteLine("1.Simple Goal - Complete once, get points once.");
            Console.WriteLine("2. Eternal Goal - Repeatable, get points each time.");
            Console.WriteLine("3. Checklist Goal - Finish N times and get a bonus on completion.");

    }