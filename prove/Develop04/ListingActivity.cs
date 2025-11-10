using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    class ListeningActivity : Activity
    {
        private int_count;
        private List<string> _promts = new()
        {
            "Who are people that you appreciate?",
            "What are your personal strenghts?",
            "Who have you helped this week?",
            "When have you felt peace recently?",
            "Who are some of your heroes?"
        };

        private Random _rng = new();

        public ListingActivity()
            : base("Listening Activiy",
                   "This activity helps you reflect on the good things in your life by listing as many as you can.")
        {
        }

        private string GetRandomPromt()
        {
            return _promts[_rng.Next(_prompts.Count)];
        }

        private List<string> GetListFromUser()
        {
            var list = new List<string>();
            DateTime end = DateTime.Now.AddSeconds(_duration);

            Console.WriteLine("\nStart listing items (press Enter after each one):");

            while (DateTime.Now < end)
            {
                Console.Write(">");
                string? item = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(item))
                    list.Add(item);
            }

            return list;
        }

        public override void Run()
        {
            DisplayStartingMessage();
            Console.WriteLine($"\n{GetRandomPromt()}");
            Console.Write("Starting in:");
            ShowCountDown(5);

            var items = GetListFromUser();
            _count = items.count;

            Console.WriteLine($"\nYou listed {_count} items);");
            foreach (var i in items)
                Console.WriteLine($" - {i}");

            DisplayEndingMessage();
        }
    }
}