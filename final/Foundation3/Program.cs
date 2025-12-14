using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address(
            "4657 W Greensand Dr",
            "West Jordan",
            "UT",
            "84084",
            "USA"
        );

        Lecture lecture = new Lecture(
            "Founders Blend West Jordan",
            "Hear from local business owners.",
            "12/13/2025",
            "7:30 AM",
            lectureAddress,
            "John Doe",
            50
        );

        Address receptionAddress = new Address(
            "2603 W Everettwood Dr",
            "Taylorsville",
            "UT",
            "84129",
            "USA"
        );

        Reception reception = new Reception(
            "Wedding Reception",
            "Celebrating Mr. and Mrs. XYZ",
            "12/13/2025",
            "6:00 PM",
            receptionAddress,
            "rsvp@gmail.com"
        );

        Address outdoorAddress = new Address(
            "4657 W Greensand Dr",
            "West Jordan",
            "UT",
            "84084",
            "USA"
        );

        OutdoorGathering gathering = new OutdoorGathering(
            "BBQ & Music Festival",
            "Live music and food",
            "12/14/2025",
            "3:45 PM",
            outdoorAddress,
            "Cloudy with light wind"
        );

        DisplayEvent(lecture);
        DisplayEvent(reception);
        DisplayEvent(gathering);
    }

    static void DisplayEvent(Event e)
    {
        Console.WriteLine("STANDARD DETAILS");
        Console.WriteLine(e.GetFullDetails());
        Console.WriteLine("\nSHORT DESCRIPTION");
        Console.WriteLine(e.GetShortDescription());
        Console.WriteLine("\n-----------------------------\n");
    }
}
