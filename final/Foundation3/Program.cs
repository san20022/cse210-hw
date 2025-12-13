using System;
class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        Console.WriteLine("Hello Foundation3 World");
        Lecture newLecture = new Lecture("Founders Blend West Jordan","Hear from two West Jordan businesses as they share about their business and important lessons they have learned.", "Saturday, December 13, 2025, "7:30 AM to 9:AM", "4657 W Greensand Dr, West Jordan, UT 84084" "West Jordan", "UT", "84084", "USA", "FirstName LastName and also FirstName LastName", 50);
        Reception newReception = Reception("Reception for Mr. and Mrs. XYZ", "The Venue at Live Oak", "12/13/2025", "10:00 AM", "2603 W Everettwood Dr", "Taylorsville", "UT", "84129", "USA", "Please RSVP by 12/4/2025 by emailing us at: ", "Wedding", "RSVP@Gmail.com");
        OutdoorGatherings newGathering = new OutdoorGatherings("Basin Red Dirt BBQ & Music Festival", "", "12/14/2025"), "3:45 PM", "4657 W Greeensand Dr", "West Jordan", "UT", "84084", "USA", "Concert", "\nWeather is expected to be cloudy, with a wind advisory. More details to com as it gets closer.");
        Console.Clear();
        Console.Write($"Standar Description:\n");
        Console.Write($"{newLecture.GetStandarDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Full Description:\n");
        Console.Write($"{newLecture.GetFullDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Short Description:\n");
        Console.Write($"{newLecture.GetShortDesc()}");
        Console.Write($"\n\n<Press Any Key>");
        Console.ReadKey();
        Console.Clear();
        Console.Write($"Standar Description:\n");
        Console.Write($"{newReception.GetStandarDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Full Description:\n");
        Console.Write($"{newReception.GetFullFetails()}");
        Console.Write($"\n\n");
        Console.Write($"Short Description:\n");
        Console.Write($"{newReception.GetShortDesc()}");
        Console.Write($"\n\n<Press Any Key>");
        Console.ReadKey();Console.Clear();
        Console.Write($"Standar Description:\n");
        Console.Write($"{newGathering.GetStandarDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Full Description:\n");
        Console.Write($"{newGathering.GetFullDetails()}");
        Console.Write($"\n\n");
        Console.Write($"Short Description:\n");
        Console.Write($"{newGathering.GetShortDesc()}");
        Console.Write($"\n\n<Press Any Key>");
        Console.ReadKey();
    }
}