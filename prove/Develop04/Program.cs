using System;

namespace MindfulnessProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Mindfulness Program");
                Console.WriteLine("-------------------");
                Console.WriteLine("1) Breating Activity");
                Console.WriteLine("2) Reflecting Activity");
                Console.WriteLine("3) Listing Activity");
                Console.WriteLine("4) Exit");
                Console.Write("\nChoose an option");

                string? choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        new BreathingActivity().Run();
                        break;
                    case "2":
                        new ReflectingActivity().Run();
                        break;
                    case "3":
                        new ListingActivity().Run();
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        System.Threading.Thread.Sleep(1000);
                        break;
                }
            }

            Console.WriteLine("\ngoodbye! Stay Mindul.");
            System.Threading.Thread.Sleep(1000);

        }
    }
}