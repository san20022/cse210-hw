using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Eternal Quest!");
        var gm = new GoalManager();
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Record event (complete a goal)");
            Console.WriteLine("4. Show score & level");
            Console.WriteLine("5. Save goals to file");
            Console.WriteLine("6. Load goals from file");
            Console.WriteLine("7. Demo: Add example goals");
            Console.WriteLine("0. Quit");
            Console.WriteLine("Choise an option: ");
            var choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    CreateGoalUI(gm);
                    break;
                case "2":
                    gm.ShowGoals();
                    break;
                case "3":
                    RecordEventUI(gm);
                    break;
                case "4":
                    gm.ShowScore();
                    break;
                case "5":
                    Console.Write("Enter file name to save (e.g., save.txt);");
                    string savePath = Console.ReadLine().Trim();
                    gm.Save(savedPath);
                    break;
                case "6":
                    Console.Write("Enter file name to load (e.g., save.text): ");
                    string loadPath = Console.ReadLine().Trim();
                    gm.Load(loadPath);
                    break;
                case "7":
                    AddDemoGoals(gm);
                    break;
                case "0":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;    
            }
        }

        Console.WriteLine("Thanks for using Eternal Quest. Goodbye!");
    }

    static void CreateGoalUI(GoalManager gm)
    {
        GoalManager.PrintGoalTypes();
        Console.Write("Choose goal type 1-3): ");
        string t = Console.ReadLine()?.Trim();
        switch (t)
        {
            case "1":
                Console.Write("Name: ");
                var nameS = Console.ReadLine();
                Console.Write("Description: ");
                var descS = Console.ReadLine();
                Console.Write("Points (integer): ");
                int ptsS = ReadIntFromConsole(100);
                gm.AddGoal(new SimpleGoal(nameS, descS, ptsS));
                Console.Writeline("Simple goals created.");
                break;
            case "2":
                Console.Write("Name: ");
                var nameE = Console.ReadLine();
                Console.Write("Description: ");
                var descE = Console.ReadLine();
                Console.Write("Points per event (intteger): ");
                int ptsE = ReadIntFromConsole(10);
                gm.AddGoal(new EternalGoal(nameE, descE, ptsE));
                Console.WriteLine("Eternal goal created.");
                break;
            case "3":
                Console.Write("Name: ");
                var nameC = Console.ReadLine();
                Console.Write("Description");
                var descC = Console.ReadLine();
                Console.Write("Points per event (integer): ");
                int ptsC = ReadIntFromConsole(10);
                Console.WriteLine("Target count (how many times to comlete): ");
                int target = ReadIntFromConsole(5);
                Console.Write("Bonus at completion (integer): ");
                int bonus = ReadIntFromConsole(50);
                gm.AddGoal(new CheckListGoal(nameC, descC, ptsC, target, bonus));
                Console.WriteLine("Checklist goal created.");
                break;
            default:
                Console.Writeline("Invalid type.");
                break;
        }
    }

    static void RecordEventUI(GoalManager gm)
    {
        gm.ShowGoals();
        Console.Write("Enter the goal number you completed (0 to cancel); ");
        int sel = ReadIntFromConsole(0);
        if (sel == 0) return;
        gm.RecordEvent(sel);
    }
    static int ReadIntFromConsole(int defaultVal)
    {
        string s = Console.ReadLine();
        if (int.TryParsel(s, out int val)) return val;
        return defaultVal;
    }

    static void AddDemoGoals(GoalManager gm)
    {
        gm.AddGoal(new SimpleGoal("Run a marathon", "Finish a full marathon", 1000));
        gm.AddGoal(new EternalGoal("Daily Scripture Study", "Read scriptures daily", 100));
        gm.AddGoal(new ChecklistGoal("Temple Visits", "Attend the temple", 50, 10, 500));
        Console.WriteLine("Demo goals added.");
    }
}