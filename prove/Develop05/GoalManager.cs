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


        
    }