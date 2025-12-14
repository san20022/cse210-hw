using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("05 Dec 2025", 60, 5));
        activities.Add(new Cycling("05 Dec 2025", 30, 15));
        activities.Add(new Swimming("05 Dec 2025", 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
