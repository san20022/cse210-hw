using System;

namespace MindfulnessProgram
{
    class BreathingActivity : Activity
    {
        public BreathingActivity()
            : base("Breathing activity",
                   "This Activity will help you relax by guiding you to breathe slowly and deeply.")
        {
        }

        public override void Run()
        {
            DisplayStartingMessage();
            DateTime end = DateTime.Now.AddSeconds(_duration);
            bool breathIn = true;

            while (DateTime.Now < end)
            {
                Console.WriteLine();
                Console.Write(breathIn ? "Breathe in... " : " Breath out...");
                ShowCountDown(breathIn ? 4 : 6);
                breatheIn = !breatheIn;
            }

            DisplayEndingMessage();
        }
    }
}