using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    class ReflectingActivity : Activity
    {
        private List<string> _promts = new()
        {
            "Think of a time when you stood up for someone else.",
            "Thing of a time when you did something really difficult.",
            "Thing of a time when you helped someone in need.",
            "Thing of a time when you acted selfessly."
        };

        private List<string> _questions = new()
        {
            "Why was this experience meaningful to you?",
            "Have you done anything similar before?",
            "How did you feel when it was complete?",
            "What did you learn from this experience?",
            "How can you apply what you learned in the future?"
        };

        private Random _rng = new();

        public ReflectingActivity()
            : base("Reflecting Activity",
                   "This activity helps you think about times when you've shown strenght and resilience.")
        {
        }

        private string GetRandomPromt()
        {
            return _promts[_rng.Next(_promts.Count)];
        }

        private string GetRandomQuestion()
        {
            return _questions[_rng.Next(_questions.Count)];
        }

        private void DisplayPromt()
        {
            Console.WriteLine($"\n{GetRandomPromt}")
            Console.WriteLine("Press Enter when you're ready...");
            Console.ReadLine();
        }

        private void DisplayQuestions()
        {
            DateTime end = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now <end)
            {
                Console.WriteLine($"\n{GetRandomQuestion()}");
                ShowSpinner(5);
            }
        }

        public override void Run()
        {
            DisplayStartingMessage();
            DisplayPromt();
            DisplayQuestions();
            DisplayEndingMessage();
        }
    }
}