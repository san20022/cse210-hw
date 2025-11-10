using System;
using System.Threading;

namespace MindfulnessProgram
{
    abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"--- {_name} ---\n");
            Console.WriteLine(_description);
            Console.Write("\nEnter durartion (in seconds): ");

            while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
            {
                Console.Write("Please enter a valid positive number:");
            }

            Console.WriteLine("\nGet ready...");
            ShowSpinner(3);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\nGreat job!");
            ShowSpinner(2);
            Console.WriteLine($"You completed the {_name} for {_duration} seconds.");
            ShowSpinner(3);
        }

        public void ShowSpinner(int seconds)
        {
            char[] spinner = { '|', '/', '-', '\\' };
            DateTime end = DateTime.Now.AddSeconds(seconds);
            int i = 0;

            while (DateTime.Now < end)
            {
                Console.Write(spinner[i]);
                Thread.Sleep(200);
                Console.Write("\b \b");
                i = (i + 1) % spinner.Length;
            }
        }

        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i >= 1; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public abstract void Run();
    }
}