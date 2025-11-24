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

            for (int i = 0; i < _goals.Count i++)
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

            var goal = _goal[goalIndex - 1];
            int gained = goal.RecordEvent();
            if (gained > 0)
            {
                _score += gained;
                Console.WriteLine($"You gained {gainded} points! New score: {_score}");
                CheckForBadges();
            }
            else
            {
                Console.WriteLine("No points gainded from that event.");
            }
        }


        public void Save(string path)
        {
            using var writer = new StreamWriter(path);

            writer.WriteLine(_score);

            write.WriteLine(string.Join(",", _badges));

            foreach (var g in _goals)
            {
                write.WriteLine(g.ToSaveString());
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

                        string name = Unescape(oarts[1]);
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
                        int target = int.Parse(part[5]);
                        int bonus = int.Parse(parts[6]);
                        loadedGoals.Add(ChecklistGoal.FromSaved(name, desc, pts, current, target, bonus));
                    }
                    else
                    {
                        Console.WriteLine($"Unknow goal type in save: {type}");
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
            Console.WriteLine($"Loaded { _goals.Count } goals.Score: {_score}. Badges: {string.Join(",", _badges)}");
        }

        private static string Unescape(string s) => s.Replace("¦", "|");


        private void CheckForBadges()
        {
            var milestone = new Dictionary<int, string>
            {
                {1000, "1000-Point Achivier"},
                {2500, "Quarter-Master"},
                {5000, "Legendary Questor"}
            };

            foreach (var kv in milestones)
            {
                if (_score >= kv.key && !_badges.Contains(kv.Value))
                {
                    _badges.Add(kv.Value);
                    Console.WriteLine(($Badge earned: {kv.Vaule } (for reaching {kv.Key} points)))
                }
            }
        }


    }