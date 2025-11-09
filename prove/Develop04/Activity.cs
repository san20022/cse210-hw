using System;
using System.Threading:

namespace MindfulnessProgram
{
    abtract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        public Activity(string name, string description)
        {
            _name = name;
            _description =description;
        }

        public void DisplayStartingMessage()
        {
            Console.Clear();
            Console.WriteLine($"--- {-name} ---\n")
            Console.WriteLine(-description);
            Console.Write("\nEnter durartion (in seconds): ");

            while (!int.TryParse(Console.ReadLine(), out _duration) || _duration <= 0)
            {
                Console.Write("Please enter a valid positive number:");
            }            
        }
    }
}