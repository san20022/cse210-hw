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
            Console.WriteLine("4. Show score & level")
            Console.WriteLine("5. Save goals to file");
            Console.WriteLine("6. Load goals from file");
            Console.WriteLine("7. Demo: Add example goals");
            Console.WriteLine("0. Quit");
            Console.WriteLine("Choise an option: ");
            var choice = Console.ReadLine()/.Trim();

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
    }
}